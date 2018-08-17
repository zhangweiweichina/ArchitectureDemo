

/* this ALWAYS GENERATED file contains the IIDs and CLSIDs */

/* link this file in with the server and any clients */


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


#ifdef __cplusplus
extern "C"{
#endif 


#include <rpc.h>
#include <rpcndr.h>

#ifdef _MIDL_USE_GUIDDEF_

#ifndef INITGUID
#define INITGUID
#include <guiddef.h>
#undef INITGUID
#else
#include <guiddef.h>
#endif

#define MIDL_DEFINE_GUID(type,name,l,w1,w2,b1,b2,b3,b4,b5,b6,b7,b8) \
        DEFINE_GUID(name,l,w1,w2,b1,b2,b3,b4,b5,b6,b7,b8)

#else // !_MIDL_USE_GUIDDEF_

#ifndef __IID_DEFINED__
#define __IID_DEFINED__

typedef struct _IID
{
    unsigned long x;
    unsigned short s1;
    unsigned short s2;
    unsigned char  c[8];
} IID;

#endif // __IID_DEFINED__

#ifndef CLSID_DEFINED
#define CLSID_DEFINED
typedef IID CLSID;
#endif // CLSID_DEFINED

#define MIDL_DEFINE_GUID(type,name,l,w1,w2,b1,b2,b3,b4,b5,b6,b7,b8) \
        const type name = {l,w1,w2,{b1,b2,b3,b4,b5,b6,b7,b8}}

#endif !_MIDL_USE_GUIDDEF_

MIDL_DEFINE_GUID(IID, IID_IMyMethod,0xAC8D541E,0x5804,0x40DF,0x90,0x2A,0xE0,0x4F,0x2D,0x0B,0x98,0xE4);


MIDL_DEFINE_GUID(IID, IID_IWelcome,0xAC8D541E,0x58e0,0x40DF,0x90,0x2A,0xE0,0x4F,0x2D,0x0B,0x98,0xE4);


MIDL_DEFINE_GUID(IID, LIBID_PlsInteropCOMServerLib,0x33EBA9C6,0x1D1A,0x4079,0xBF,0xD3,0x17,0xB6,0xB3,0xA1,0x5D,0x08);


MIDL_DEFINE_GUID(IID, DIID__ICompletedEvents,0xAC8D541E,0x58e0,0x40DF,0x90,0x2A,0xE0,0x4F,0x2D,0xEB,0x98,0xE4);


MIDL_DEFINE_GUID(CLSID, CLSID_MyMethod,0xC0830455,0x8EDD,0x4820,0x90,0xD5,0x43,0x77,0xC0,0x34,0xA9,0x50);

#undef MIDL_DEFINE_GUID

#ifdef __cplusplus
}
#endif



