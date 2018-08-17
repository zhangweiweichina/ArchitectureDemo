// MyMethod.cpp : Implementation of CMyMethod

#include "stdafx.h"
#include "MyMethod.h"


// CMyMethod



STDMETHODIMP CMyMethod::Add(DOUBLE x, DOUBLE y, DOUBLE* res)
{
	AFX_MANAGE_STATE(AfxGetStaticModuleState());

	// TODO: Add your implementation code here
	*res = x+y;
	Fire_Completed();
	return S_OK;
}


STDMETHODIMP CMyMethod::Greeting(BSTR name, BSTR* message)
{
	AFX_MANAGE_STATE(AfxGetStaticModuleState());

	// TODO: Add your implementation code here
	CComBSTR tmp(_T("Welcome"));
	tmp.Append(name);
	*message = tmp;
	Fire_Completed();
	return S_OK;
	
}
