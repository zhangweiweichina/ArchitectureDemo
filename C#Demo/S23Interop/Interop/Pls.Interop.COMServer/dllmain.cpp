// dllmain.cpp : Implementation of DllMain.

#include "stdafx.h"
#include "resource.h"
#include "PlsInteropCOMServer_i.h"
#include "dllmain.h"

CPlsInteropCOMServerModule _AtlModule;

class CPlsInteropCOMServerApp : public CWinApp
{
public:

// Overrides
	virtual BOOL InitInstance();
	virtual int ExitInstance();

	DECLARE_MESSAGE_MAP()
};

BEGIN_MESSAGE_MAP(CPlsInteropCOMServerApp, CWinApp)
END_MESSAGE_MAP()

CPlsInteropCOMServerApp theApp;

BOOL CPlsInteropCOMServerApp::InitInstance()
{
	return CWinApp::InitInstance();
}

int CPlsInteropCOMServerApp::ExitInstance()
{
	return CWinApp::ExitInstance();
}
