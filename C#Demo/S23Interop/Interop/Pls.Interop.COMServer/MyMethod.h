// MyMethod.h : Declaration of the CMyMethod

#pragma once
#include "resource.h"       // main symbols



#include "PlsInteropCOMServer_i.h"
#include "_ICompletedEvents_CP.H"



#if defined(_WIN32_WCE) && !defined(_CE_DCOM) && !defined(_CE_ALLOW_SINGLE_THREADED_OBJECTS_IN_MTA)
#error "Single-threaded COM objects are not properly supported on Windows CE platform, such as the Windows Mobile platforms that do not include full DCOM support. Define _CE_ALLOW_SINGLE_THREADED_OBJECTS_IN_MTA to force ATL to support creating single-thread COM object's and allow use of it's single-threaded COM object implementations. The threading model in your rgs file was set to 'Free' as that is the only threading model supported in non DCOM Windows CE platforms."
#endif

using namespace ATL;


// CMyMethod

class ATL_NO_VTABLE CMyMethod :
	public CComObjectRootEx<CComSingleThreadModel>,
	public CComCoClass<CMyMethod, &CLSID_MyMethod>,
	public IDispatchImpl<IMyMethod, &IID_IMyMethod, &LIBID_PlsInteropCOMServerLib, /*wMajor =*/ 1, /*wMinor =*/ 0>,
	public IDispatchImpl<IWelcome, &IID_IWelcome, &LIBID_PlsInteropCOMServerLib, /*wMajor =*/ 1, /*wMinor =*/ 0>,
	public IConnectionPointContainerImpl<CMyMethod>,
	public CProxy_ICompletedEvents<CMyMethod>
{
public:
	CMyMethod()
	{
	}

DECLARE_REGISTRY_RESOURCEID(IDR_MYMETHOD)


BEGIN_COM_MAP(CMyMethod)
	COM_INTERFACE_ENTRY(IMyMethod)
	COM_INTERFACE_ENTRY(IWelcome)
	COM_INTERFACE_ENTRY2(IDispatch,IWelcome)
	COM_INTERFACE_ENTRY(IConnectionPointContainer)
END_COM_MAP()
//COM_INTERFACE_ENTRY2 因为IMyMethod/IWelcome都来自于IDispatch,所以需要指定如果用户需要IDispatch时，返回哪个接口


	DECLARE_PROTECT_FINAL_CONSTRUCT()

	HRESULT FinalConstruct()
	{
		return S_OK;
	}

	void FinalRelease()
	{
	}

public:



	STDMETHOD(Add)(DOUBLE x, DOUBLE y, DOUBLE* res);
	
	STDMETHOD(Greeting)(BSTR name, BSTR* message);
	BEGIN_CONNECTION_POINT_MAP(CMyMethod)
		CONNECTION_POINT_ENTRY(__uuidof(_ICompletedEvents))
	END_CONNECTION_POINT_MAP()
};

OBJECT_ENTRY_AUTO(__uuidof(MyMethod), CMyMethod)
