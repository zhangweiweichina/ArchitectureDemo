// dllmain.h : Declaration of module class.

class CPlsInteropCOMServerModule : public ATL::CAtlDllModuleT< CPlsInteropCOMServerModule >
{
public :
	DECLARE_LIBID(LIBID_PlsInteropCOMServerLib)
	DECLARE_REGISTRY_APPID_RESOURCEID(IDR_PLSINTEROPCOMSERVER, "{831056B2-3613-49D7-8328-361244086E65}")
};

extern class CPlsInteropCOMServerModule _AtlModule;
