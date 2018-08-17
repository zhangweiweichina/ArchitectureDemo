

/* this ALWAYS GENERATED file contains the definitions for the interfaces */


 /* File created by MIDL compiler version 8.00.0595 */
/* at Fri Aug 17 00:16:42 2018
 */
/* Compiler settings for PlsInteropCOMServer.idl:
    Oicf, W1, Zp8, env=Win32 (32b run), target_arch=X86 8.00.0595 
    protocol : dce , ms_ext, c_ext, robust
    error checks: allocation ref bounds_check enum stub_data 
    VC __declspec() decoration level: 
         __declspec(uuid()), __declspec(selectany), __declspec(novtable)
         DECLSPEC_UUID(), MIDL_INTERFACE()
*/
/* @@MIDL_FILE_HEADING(  ) */

#pragma warning( disable: 4049 )  /* more than 64k source lines */


/* verify that the <rpcndr.h> version is high enough to compile this file*/
#ifndef __REQUIRED_RPCNDR_H_VERSION__
#define __REQUIRED_RPCNDR_H_VERSION__ 475
#endif

#include "rpc.h"
#include "rpcndr.h"

#ifndef __RPCNDR_H_VERSION__
#error this stub requires an updated version of <rpcndr.h>
#endif // __RPCNDR_H_VERSION__

#ifndef COM_NO_WINDOWS_H
#include "windows.h"
#include "ole2.h"
#endif /*COM_NO_WINDOWS_H*/

#ifndef __PlsInteropCOMServer_i_h__
#define __PlsInteropCOMServer_i_h__

#if defined(_MSC_VER) && (_MSC_VER >= 1020)
#pragma once
#endif

/* Forward Declarations */ 

#ifndef __IMyMethod_FWD_DEFINED__
#define __IMyMethod_FWD_DEFINED__
typedef interface IMyMethod IMyMethod;

#endif 	/* __IMyMethod_FWD_DEFINED__ */


#ifndef __IWelcome_FWD_DEFINED__
#define __IWelcome_FWD_DEFINED__
typedef interface IWelcome IWelcome;

#endif 	/* __IWelcome_FWD_DEFINED__ */


#ifndef ___ICompletedEvents_FWD_DEFINED__
#define ___ICompletedEvents_FWD_DEFINED__
typedef interface _ICompletedEvents _ICompletedEvents;

#endif 	/* ___ICompletedEvents_FWD_DEFINED__ */


#ifndef __MyMethod_FWD_DEFINED__
#define __MyMethod_FWD_DEFINED__

#ifdef __cplusplus
typedef class MyMethod MyMethod;
#else
typedef struct MyMethod MyMethod;
#endif /* __cplusplus */

#endif 	/* __MyMethod_FWD_DEFINED__ */


/* header files for imported files */
#include "oaidl.h"
#include "ocidl.h"

#ifdef __cplusplus
extern "C"{
#endif 


#ifndef __IMyMethod_INTERFACE_DEFINED__
#define __IMyMethod_INTERFACE_DEFINED__

/* interface IMyMethod */
/* [custom][unique][nonextensible][dual][uuid][object] */ 


EXTERN_C const IID IID_IMyMethod;

#if defined(__cplusplus) && !defined(CINTERFACE)
    
    MIDL_INTERFACE("AC8D541E-5804-40DF-902A-E04F2D0B98E4")
    IMyMethod : public IDispatch
    {
    public:
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE Add( 
            /* [in] */ DOUBLE x,
            /* [in] */ DOUBLE y,
            /* [out] */ DOUBLE *res) = 0;
        
    };
    
    
#else 	/* C style interface */

    typedef struct IMyMethodVtbl
    {
        BEGIN_INTERFACE
        
        HRESULT ( STDMETHODCALLTYPE *QueryInterface )( 
            IMyMethod * This,
            /* [in] */ REFIID riid,
            /* [annotation][iid_is][out] */ 
            _COM_Outptr_  void **ppvObject);
        
        ULONG ( STDMETHODCALLTYPE *AddRef )( 
            IMyMethod * This);
        
        ULONG ( STDMETHODCALLTYPE *Release )( 
            IMyMethod * This);
        
        HRESULT ( STDMETHODCALLTYPE *GetTypeInfoCount )( 
            IMyMethod * This,
            /* [out] */ UINT *pctinfo);
        
        HRESULT ( STDMETHODCALLTYPE *GetTypeInfo )( 
            IMyMethod * This,
            /* [in] */ UINT iTInfo,
            /* [in] */ LCID lcid,
            /* [out] */ ITypeInfo **ppTInfo);
        
        HRESULT ( STDMETHODCALLTYPE *GetIDsOfNames )( 
            IMyMethod * This,
            /* [in] */ REFIID riid,
            /* [size_is][in] */ LPOLESTR *rgszNames,
            /* [range][in] */ UINT cNames,
            /* [in] */ LCID lcid,
            /* [size_is][out] */ DISPID *rgDispId);
        
        /* [local] */ HRESULT ( STDMETHODCALLTYPE *Invoke )( 
            IMyMethod * This,
            /* [annotation][in] */ 
            _In_  DISPID dispIdMember,
            /* [annotation][in] */ 
            _In_  REFIID riid,
            /* [annotation][in] */ 
            _In_  LCID lcid,
            /* [annotation][in] */ 
            _In_  WORD wFlags,
            /* [annotation][out][in] */ 
            _In_  DISPPARAMS *pDispParams,
            /* [annotation][out] */ 
            _Out_opt_  VARIANT *pVarResult,
            /* [annotation][out] */ 
            _Out_opt_  EXCEPINFO *pExcepInfo,
            /* [annotation][out] */ 
            _Out_opt_  UINT *puArgErr);
        
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *Add )( 
            IMyMethod * This,
            /* [in] */ DOUBLE x,
            /* [in] */ DOUBLE y,
            /* [out] */ DOUBLE *res);
        
        END_INTERFACE
    } IMyMethodVtbl;

    interface IMyMethod
    {
        CONST_VTBL struct IMyMethodVtbl *lpVtbl;
    };

    

#ifdef COBJMACROS


#define IMyMethod_QueryInterface(This,riid,ppvObject)	\
    ( (This)->lpVtbl -> QueryInterface(This,riid,ppvObject) ) 

#define IMyMethod_AddRef(This)	\
    ( (This)->lpVtbl -> AddRef(This) ) 

#define IMyMethod_Release(This)	\
    ( (This)->lpVtbl -> Release(This) ) 


#define IMyMethod_GetTypeInfoCount(This,pctinfo)	\
    ( (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo) ) 

#define IMyMethod_GetTypeInfo(This,iTInfo,lcid,ppTInfo)	\
    ( (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo) ) 

#define IMyMethod_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)	\
    ( (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) ) 

#define IMyMethod_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)	\
    ( (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) ) 


#define IMyMethod_Add(This,x,y,res)	\
    ( (This)->lpVtbl -> Add(This,x,y,res) ) 

#endif /* COBJMACROS */


#endif 	/* C style interface */




#endif 	/* __IMyMethod_INTERFACE_DEFINED__ */


#ifndef __IWelcome_INTERFACE_DEFINED__
#define __IWelcome_INTERFACE_DEFINED__

/* interface IWelcome */
/* [custom][unique][nonextensible][dual][uuid][object] */ 


EXTERN_C const IID IID_IWelcome;

#if defined(__cplusplus) && !defined(CINTERFACE)
    
    MIDL_INTERFACE("AC8D541E-58e0-40DF-902A-E04F2D0B98E4")
    IWelcome : public IDispatch
    {
    public:
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE Greeting( 
            /* [in] */ BSTR name,
            /* [retval][out] */ BSTR *message) = 0;
        
    };
    
    
#else 	/* C style interface */

    typedef struct IWelcomeVtbl
    {
        BEGIN_INTERFACE
        
        HRESULT ( STDMETHODCALLTYPE *QueryInterface )( 
            IWelcome * This,
            /* [in] */ REFIID riid,
            /* [annotation][iid_is][out] */ 
            _COM_Outptr_  void **ppvObject);
        
        ULONG ( STDMETHODCALLTYPE *AddRef )( 
            IWelcome * This);
        
        ULONG ( STDMETHODCALLTYPE *Release )( 
            IWelcome * This);
        
        HRESULT ( STDMETHODCALLTYPE *GetTypeInfoCount )( 
            IWelcome * This,
            /* [out] */ UINT *pctinfo);
        
        HRESULT ( STDMETHODCALLTYPE *GetTypeInfo )( 
            IWelcome * This,
            /* [in] */ UINT iTInfo,
            /* [in] */ LCID lcid,
            /* [out] */ ITypeInfo **ppTInfo);
        
        HRESULT ( STDMETHODCALLTYPE *GetIDsOfNames )( 
            IWelcome * This,
            /* [in] */ REFIID riid,
            /* [size_is][in] */ LPOLESTR *rgszNames,
            /* [range][in] */ UINT cNames,
            /* [in] */ LCID lcid,
            /* [size_is][out] */ DISPID *rgDispId);
        
        /* [local] */ HRESULT ( STDMETHODCALLTYPE *Invoke )( 
            IWelcome * This,
            /* [annotation][in] */ 
            _In_  DISPID dispIdMember,
            /* [annotation][in] */ 
            _In_  REFIID riid,
            /* [annotation][in] */ 
            _In_  LCID lcid,
            /* [annotation][in] */ 
            _In_  WORD wFlags,
            /* [annotation][out][in] */ 
            _In_  DISPPARAMS *pDispParams,
            /* [annotation][out] */ 
            _Out_opt_  VARIANT *pVarResult,
            /* [annotation][out] */ 
            _Out_opt_  EXCEPINFO *pExcepInfo,
            /* [annotation][out] */ 
            _Out_opt_  UINT *puArgErr);
        
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *Greeting )( 
            IWelcome * This,
            /* [in] */ BSTR name,
            /* [retval][out] */ BSTR *message);
        
        END_INTERFACE
    } IWelcomeVtbl;

    interface IWelcome
    {
        CONST_VTBL struct IWelcomeVtbl *lpVtbl;
    };

    

#ifdef COBJMACROS


#define IWelcome_QueryInterface(This,riid,ppvObject)	\
    ( (This)->lpVtbl -> QueryInterface(This,riid,ppvObject) ) 

#define IWelcome_AddRef(This)	\
    ( (This)->lpVtbl -> AddRef(This) ) 

#define IWelcome_Release(This)	\
    ( (This)->lpVtbl -> Release(This) ) 


#define IWelcome_GetTypeInfoCount(This,pctinfo)	\
    ( (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo) ) 

#define IWelcome_GetTypeInfo(This,iTInfo,lcid,ppTInfo)	\
    ( (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo) ) 

#define IWelcome_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)	\
    ( (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) ) 

#define IWelcome_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)	\
    ( (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) ) 


#define IWelcome_Greeting(This,name,message)	\
    ( (This)->lpVtbl -> Greeting(This,name,message) ) 

#endif /* COBJMACROS */


#endif 	/* C style interface */




#endif 	/* __IWelcome_INTERFACE_DEFINED__ */



#ifndef __PlsInteropCOMServerLib_LIBRARY_DEFINED__
#define __PlsInteropCOMServerLib_LIBRARY_DEFINED__

/* library PlsInteropCOMServerLib */
/* [version][uuid] */ 


EXTERN_C const IID LIBID_PlsInteropCOMServerLib;

#ifndef ___ICompletedEvents_DISPINTERFACE_DEFINED__
#define ___ICompletedEvents_DISPINTERFACE_DEFINED__

/* dispinterface _ICompletedEvents */
/* [helpstring][uuid] */ 


EXTERN_C const IID DIID__ICompletedEvents;

#if defined(__cplusplus) && !defined(CINTERFACE)

    MIDL_INTERFACE("AC8D541E-58e0-40DF-902A-E04F2DEB98E4")
    _ICompletedEvents : public IDispatch
    {
    };
    
#else 	/* C style interface */

    typedef struct _ICompletedEventsVtbl
    {
        BEGIN_INTERFACE
        
        HRESULT ( STDMETHODCALLTYPE *QueryInterface )( 
            _ICompletedEvents * This,
            /* [in] */ REFIID riid,
            /* [annotation][iid_is][out] */ 
            _COM_Outptr_  void **ppvObject);
        
        ULONG ( STDMETHODCALLTYPE *AddRef )( 
            _ICompletedEvents * This);
        
        ULONG ( STDMETHODCALLTYPE *Release )( 
            _ICompletedEvents * This);
        
        HRESULT ( STDMETHODCALLTYPE *GetTypeInfoCount )( 
            _ICompletedEvents * This,
            /* [out] */ UINT *pctinfo);
        
        HRESULT ( STDMETHODCALLTYPE *GetTypeInfo )( 
            _ICompletedEvents * This,
            /* [in] */ UINT iTInfo,
            /* [in] */ LCID lcid,
            /* [out] */ ITypeInfo **ppTInfo);
        
        HRESULT ( STDMETHODCALLTYPE *GetIDsOfNames )( 
            _ICompletedEvents * This,
            /* [in] */ REFIID riid,
            /* [size_is][in] */ LPOLESTR *rgszNames,
            /* [range][in] */ UINT cNames,
            /* [in] */ LCID lcid,
            /* [size_is][out] */ DISPID *rgDispId);
        
        /* [local] */ HRESULT ( STDMETHODCALLTYPE *Invoke )( 
            _ICompletedEvents * This,
            /* [annotation][in] */ 
            _In_  DISPID dispIdMember,
            /* [annotation][in] */ 
            _In_  REFIID riid,
            /* [annotation][in] */ 
            _In_  LCID lcid,
            /* [annotation][in] */ 
            _In_  WORD wFlags,
            /* [annotation][out][in] */ 
            _In_  DISPPARAMS *pDispParams,
            /* [annotation][out] */ 
            _Out_opt_  VARIANT *pVarResult,
            /* [annotation][out] */ 
            _Out_opt_  EXCEPINFO *pExcepInfo,
            /* [annotation][out] */ 
            _Out_opt_  UINT *puArgErr);
        
        END_INTERFACE
    } _ICompletedEventsVtbl;

    interface _ICompletedEvents
    {
        CONST_VTBL struct _ICompletedEventsVtbl *lpVtbl;
    };

    

#ifdef COBJMACROS


#define _ICompletedEvents_QueryInterface(This,riid,ppvObject)	\
    ( (This)->lpVtbl -> QueryInterface(This,riid,ppvObject) ) 

#define _ICompletedEvents_AddRef(This)	\
    ( (This)->lpVtbl -> AddRef(This) ) 

#define _ICompletedEvents_Release(This)	\
    ( (This)->lpVtbl -> Release(This) ) 


#define _ICompletedEvents_GetTypeInfoCount(This,pctinfo)	\
    ( (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo) ) 

#define _ICompletedEvents_GetTypeInfo(This,iTInfo,lcid,ppTInfo)	\
    ( (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo) ) 

#define _ICompletedEvents_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)	\
    ( (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) ) 

#define _ICompletedEvents_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)	\
    ( (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) ) 

#endif /* COBJMACROS */


#endif 	/* C style interface */


#endif 	/* ___ICompletedEvents_DISPINTERFACE_DEFINED__ */


EXTERN_C const CLSID CLSID_MyMethod;

#ifdef __cplusplus

class DECLSPEC_UUID("C0830455-8EDD-4820-90D5-4377C034A950")
MyMethod;
#endif
#endif /* __PlsInteropCOMServerLib_LIBRARY_DEFINED__ */

/* Additional Prototypes for ALL interfaces */

unsigned long             __RPC_USER  BSTR_UserSize(     unsigned long *, unsigned long            , BSTR * ); 
unsigned char * __RPC_USER  BSTR_UserMarshal(  unsigned long *, unsigned char *, BSTR * ); 
unsigned char * __RPC_USER  BSTR_UserUnmarshal(unsigned long *, unsigned char *, BSTR * ); 
void                      __RPC_USER  BSTR_UserFree(     unsigned long *, BSTR * ); 

/* end of Additional Prototypes */

#ifdef __cplusplus
}
#endif

#endif


