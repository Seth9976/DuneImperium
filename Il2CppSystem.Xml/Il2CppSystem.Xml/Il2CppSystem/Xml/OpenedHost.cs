using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000091 RID: 145
	public class OpenedHost : Object
	{
		// Token: 0x060010E6 RID: 4326 RVA: 0x000606AC File Offset: 0x0005E8AC
		// Note: this type is marked as 'beforefieldinit'.
		static OpenedHost()
		{
			Il2CppClassPointerStore<OpenedHost>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "OpenedHost");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OpenedHost>.NativeClassPtr);
			OpenedHost.NativeFieldInfoPtr_nonCachedConnectionsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpenedHost>.NativeClassPtr, "nonCachedConnectionsCount");
			OpenedHost.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpenedHost>.NativeClassPtr, 100666107);
		}

		// Token: 0x060010E7 RID: 4327 RVA: 0x00060704 File Offset: 0x0005E904
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OpenedHost()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OpenedHost>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OpenedHost.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010E8 RID: 4328 RVA: 0x0000759D File Offset: 0x0000579D
		public OpenedHost(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x060010E9 RID: 4329 RVA: 0x00060740 File Offset: 0x0005E940
		// (set) Token: 0x060010EA RID: 4330 RVA: 0x000075A6 File Offset: 0x000057A6
		public unsafe int nonCachedConnectionsCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OpenedHost.NativeFieldInfoPtr_nonCachedConnectionsCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OpenedHost.NativeFieldInfoPtr_nonCachedConnectionsCount)) = value;
			}
		}

		// Token: 0x04000DD5 RID: 3541
		private static readonly IntPtr NativeFieldInfoPtr_nonCachedConnectionsCount;

		// Token: 0x04000DD6 RID: 3542
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
