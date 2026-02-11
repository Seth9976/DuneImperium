using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Xml;

namespace Il2CppSystem.Diagnostics
{
	// Token: 0x02000280 RID: 640
	public class DiagnosticsConfigurationHandler : Object
	{
		// Token: 0x06002996 RID: 10646 RVA: 0x000BC458 File Offset: 0x000BA658
		// Note: this type is marked as 'beforefieldinit'.
		static DiagnosticsConfigurationHandler()
		{
			Il2CppClassPointerStore<DiagnosticsConfigurationHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Diagnostics", "DiagnosticsConfigurationHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DiagnosticsConfigurationHandler>.NativeClassPtr);
			DiagnosticsConfigurationHandler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiagnosticsConfigurationHandler>.NativeClassPtr, 100669472);
			DiagnosticsConfigurationHandler.NativeMethodInfoPtr_Create_Public_Virtual_New_Object_Object_Object_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiagnosticsConfigurationHandler>.NativeClassPtr, 100669473);
		}

		// Token: 0x06002997 RID: 10647 RVA: 0x000BC4B0 File Offset: 0x000BA6B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 494273, XrefRangeEnd = 494276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DiagnosticsConfigurationHandler()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DiagnosticsConfigurationHandler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiagnosticsConfigurationHandler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002998 RID: 10648 RVA: 0x000BC4EC File Offset: 0x000BA6EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 494276, XrefRangeEnd = 494279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object Create(Object parent, Object configContext, XmlNode section)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(configContext);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(section);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DiagnosticsConfigurationHandler.NativeMethodInfoPtr_Create_Public_Virtual_New_Object_Object_Object_XmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06002999 RID: 10649 RVA: 0x00011DF7 File Offset: 0x0000FFF7
		public DiagnosticsConfigurationHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040020EB RID: 8427
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040020EC RID: 8428
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Virtual_New_Object_Object_Object_XmlNode_0;
	}
}
