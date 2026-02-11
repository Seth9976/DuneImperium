using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.ComponentModel;

namespace Il2CppSystem.Diagnostics
{
	// Token: 0x020000A7 RID: 167
	public class MonitoringDescriptionAttribute : DescriptionAttribute
	{
		// Token: 0x06000C48 RID: 3144 RVA: 0x00049CF0 File Offset: 0x00047EF0
		// Note: this type is marked as 'beforefieldinit'.
		static MonitoringDescriptionAttribute()
		{
			Il2CppClassPointerStore<MonitoringDescriptionAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Diagnostics", "MonitoringDescriptionAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonitoringDescriptionAttribute>.NativeClassPtr);
			MonitoringDescriptionAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonitoringDescriptionAttribute>.NativeClassPtr, 100665056);
			MonitoringDescriptionAttribute.NativeMethodInfoPtr_get_Description_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonitoringDescriptionAttribute>.NativeClassPtr, 100665057);
		}

		// Token: 0x06000C49 RID: 3145 RVA: 0x00049D48 File Offset: 0x00047F48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 451892, XrefRangeEnd = 451896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonitoringDescriptionAttribute(string description)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonitoringDescriptionAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(description);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonitoringDescriptionAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06000C4A RID: 3146 RVA: 0x00049D94 File Offset: 0x00047F94
		public unsafe override string Description
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 451896, XrefRangeEnd = 451897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonitoringDescriptionAttribute.NativeMethodInfoPtr_get_Description_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000C4B RID: 3147 RVA: 0x00006936 File Offset: 0x00004B36
		public MonitoringDescriptionAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040009A3 RID: 2467
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040009A4 RID: 2468
		private static readonly IntPtr NativeMethodInfoPtr_get_Description_Public_Virtual_get_String_0;
	}
}
