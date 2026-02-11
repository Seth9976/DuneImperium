using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x0200010A RID: 266
	public class CallSite : Object
	{
		// Token: 0x06000FE6 RID: 4070 RVA: 0x00053C14 File Offset: 0x00051E14
		// Note: this type is marked as 'beforefieldinit'.
		static CallSite()
		{
			Il2CppClassPointerStore<CallSite>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Runtime.CompilerServices", "CallSite");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallSite>.NativeClassPtr);
			CallSite.NativeFieldInfoPtr__binder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallSite>.NativeClassPtr, "_binder");
			CallSite.NativeFieldInfoPtr__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallSite>.NativeClassPtr, "_match");
			CallSite.NativeMethodInfoPtr__ctor_Internal_Void_CallSiteBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSite>.NativeClassPtr, 100666259);
			CallSite.NativeMethodInfoPtr_get_Binder_Public_get_CallSiteBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSite>.NativeClassPtr, 100666260);
		}

		// Token: 0x06000FE7 RID: 4071 RVA: 0x00053C94 File Offset: 0x00051E94
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallSite(CallSiteBinder binder)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallSite>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(binder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSite.NativeMethodInfoPtr__ctor_Internal_Void_CallSiteBinder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06000FE8 RID: 4072 RVA: 0x00053CE0 File Offset: 0x00051EE0
		public unsafe CallSiteBinder Binder
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSite.NativeMethodInfoPtr_get_Binder_Public_get_CallSiteBinder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CallSiteBinder>(intPtr3) : null;
			}
		}

		// Token: 0x06000FE9 RID: 4073 RVA: 0x00006F72 File Offset: 0x00005172
		public CallSite(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06000FEA RID: 4074 RVA: 0x00053D20 File Offset: 0x00051F20
		// (set) Token: 0x06000FEB RID: 4075 RVA: 0x00006F7B File Offset: 0x0000517B
		public unsafe CallSiteBinder _binder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallSite.NativeFieldInfoPtr__binder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CallSiteBinder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallSite.NativeFieldInfoPtr__binder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06000FEC RID: 4076 RVA: 0x00053D50 File Offset: 0x00051F50
		// (set) Token: 0x06000FED RID: 4077 RVA: 0x00006F9A File Offset: 0x0000519A
		public unsafe bool _match
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallSite.NativeFieldInfoPtr__match);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallSite.NativeFieldInfoPtr__match)) = value;
			}
		}

		// Token: 0x04000B6A RID: 2922
		private static readonly IntPtr NativeFieldInfoPtr__binder;

		// Token: 0x04000B6B RID: 2923
		private static readonly IntPtr NativeFieldInfoPtr__match;

		// Token: 0x04000B6C RID: 2924
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_CallSiteBinder_0;

		// Token: 0x04000B6D RID: 2925
		private static readonly IntPtr NativeMethodInfoPtr_get_Binder_Public_get_CallSiteBinder_0;
	}
}
