using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace dwd.core.endorsement
{
	// Token: 0x020001BA RID: 442
	public class Request : Object
	{
		// Token: 0x06001896 RID: 6294 RVA: 0x00075ECC File Offset: 0x000740CC
		// Note: this type is marked as 'beforefieldinit'.
		static Request()
		{
			Il2CppClassPointerStore<Request>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.endorsement", "Request");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Request>.NativeClassPtr);
			Request.NativeFieldInfoPtr__Denied_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Request>.NativeClassPtr, "<Denied>k__BackingField");
			Request.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100667218);
			Request.NativeMethodInfoPtr_get_Denied_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100667219);
			Request.NativeMethodInfoPtr_set_Denied_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100667220);
			Request.NativeMethodInfoPtr_Deny_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100667221);
		}

		// Token: 0x06001897 RID: 6295 RVA: 0x00075F60 File Offset: 0x00074160
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 880491, RefRangeEnd = 880498, XrefRangeStart = 880491, XrefRangeEnd = 880498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Request()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Request>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Request.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x06001898 RID: 6296 RVA: 0x00075F9C File Offset: 0x0007419C
		// (set) Token: 0x06001899 RID: 6297 RVA: 0x00075FD8 File Offset: 0x000741D8
		public unsafe bool Denied
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Request.NativeMethodInfoPtr_get_Denied_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 288083, RefRangeEnd = 288084, XrefRangeStart = 288083, XrefRangeEnd = 288084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Request.NativeMethodInfoPtr_set_Denied_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600189A RID: 6298 RVA: 0x00076018 File Offset: 0x00074218
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 478427, RefRangeEnd = 478428, XrefRangeStart = 478427, XrefRangeEnd = 478428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Deny()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Request.NativeMethodInfoPtr_Deny_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600189B RID: 6299 RVA: 0x0000AD1F File Offset: 0x00008F1F
		public Request(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x0600189C RID: 6300 RVA: 0x0007604C File Offset: 0x0007424C
		// (set) Token: 0x0600189D RID: 6301 RVA: 0x0000AD28 File Offset: 0x00008F28
		public unsafe bool _Denied_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__Denied_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__Denied_k__BackingField)) = value;
			}
		}

		// Token: 0x04001155 RID: 4437
		private static readonly IntPtr NativeFieldInfoPtr__Denied_k__BackingField;

		// Token: 0x04001156 RID: 4438
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001157 RID: 4439
		private static readonly IntPtr NativeMethodInfoPtr_get_Denied_Public_get_Boolean_0;

		// Token: 0x04001158 RID: 4440
		private static readonly IntPtr NativeMethodInfoPtr_set_Denied_Private_set_Void_Boolean_0;

		// Token: 0x04001159 RID: 4441
		private static readonly IntPtr NativeMethodInfoPtr_Deny_Public_Void_0;
	}
}
