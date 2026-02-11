using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Dynamic;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000055 RID: 85
	public class NoThrowSetBinderMember : SetMemberBinder
	{
		// Token: 0x060007CD RID: 1997 RVA: 0x00037230 File Offset: 0x00035430
		// Note: this type is marked as 'beforefieldinit'.
		static NoThrowSetBinderMember()
		{
			Il2CppClassPointerStore<NoThrowSetBinderMember>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Utilities", "NoThrowSetBinderMember");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoThrowSetBinderMember>.NativeClassPtr);
			NoThrowSetBinderMember.NativeFieldInfoPtr__innerBinder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoThrowSetBinderMember>.NativeClassPtr, "_innerBinder");
			NoThrowSetBinderMember.NativeMethodInfoPtr__ctor_Public_Void_SetMemberBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoThrowSetBinderMember>.NativeClassPtr, 100664821);
			NoThrowSetBinderMember.NativeMethodInfoPtr_FallbackSetMember_Public_Virtual_DynamicMetaObject_DynamicMetaObject_DynamicMetaObject_DynamicMetaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoThrowSetBinderMember>.NativeClassPtr, 100664822);
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x0003729C File Offset: 0x0003549C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 743092, RefRangeEnd = 743093, XrefRangeStart = 743089, XrefRangeEnd = 743092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NoThrowSetBinderMember(SetMemberBinder innerBinder)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoThrowSetBinderMember>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(innerBinder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoThrowSetBinderMember.NativeMethodInfoPtr__ctor_Public_Void_SetMemberBinder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x000372E8 File Offset: 0x000354E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 743093, XrefRangeEnd = 743106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DynamicMetaObject FallbackSetMember(DynamicMetaObject target, DynamicMetaObject value, DynamicMetaObject errorSuggestion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(errorSuggestion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoThrowSetBinderMember.NativeMethodInfoPtr_FallbackSetMember_Public_Virtual_DynamicMetaObject_DynamicMetaObject_DynamicMetaObject_DynamicMetaObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x00004655 File Offset: 0x00002855
		public NoThrowSetBinderMember(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x060007D1 RID: 2001 RVA: 0x00037368 File Offset: 0x00035568
		// (set) Token: 0x060007D2 RID: 2002 RVA: 0x0000465E File Offset: 0x0000285E
		public unsafe SetMemberBinder _innerBinder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoThrowSetBinderMember.NativeFieldInfoPtr__innerBinder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SetMemberBinder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoThrowSetBinderMember.NativeFieldInfoPtr__innerBinder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006CF RID: 1743
		private static readonly IntPtr NativeFieldInfoPtr__innerBinder;

		// Token: 0x040006D0 RID: 1744
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SetMemberBinder_0;

		// Token: 0x040006D1 RID: 1745
		private static readonly IntPtr NativeMethodInfoPtr_FallbackSetMember_Public_Virtual_DynamicMetaObject_DynamicMetaObject_DynamicMetaObject_DynamicMetaObject_0;
	}
}
