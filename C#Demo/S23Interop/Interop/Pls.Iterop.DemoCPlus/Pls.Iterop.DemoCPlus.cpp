// Pls.Iterop.DemoCPlus.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "objbase.h"

#import "Pls.Interop.COMNet.tlb"

int _tmain(int argc, _TCHAR* argv[])
{
	CoInitialize(NULL);
	Pls_Interop_COMNet::IMethodPtr p(__uuidof(Pls_Interop_COMNet::Method));

	double db = p->Add(1,2);
	return 0;
}

