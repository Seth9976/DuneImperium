using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Dynamic;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000054 RID: 84
	public class NoThrowGetBinderMember : GetMemberBinder
	{
		// Token: 0x060007C7 RID: 1991 RVA: 0x000370D8 File Offset: 0x000352D8
		// Note: this type is marked as 'beforefieldinit'.
		static NoThrowGetBinderMember()
		{
			Il2CppClassPointerStore<NoThrowGetBinderMember>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Utilities", "NoThrowGetBinderMember");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoThrowGetBinderMember>.NativeClassPtr);
			NoThrowGetBinderMember.NativeFieldInfoPtr__innerBinder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoThrowGetBinderMember>.NativeClassPtr, "_innerBinder");
			NoThrowGetBinderMember.NativeMethodInfoPtr__ctor_Public_Void_GetMemberBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoThrowGetBinderMember>.NativeClassPtr, 100664819);
			NoThrowGetBinderMember.NativeMethodInfoPtr_FallbackGetMember_Public_Virtual_DynamicMetaObject_DynamicMetaObject_DynamicMetaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoThrowGetBinderMember>.NativeClassPtr, 100664820);
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x00037144 File Offset: 0x00035344
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 743074, RefRangeEnd = 743075, XrefRangeStart = 743071, XrefRangeEnd = 743074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NoThrowGetBinderMember(GetMemberBinder innerBinder)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoThrowGetBinderMember>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(innerBinder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoThrowGetBinderMember.NativeMethodInfoPtr__ctor_Public_Void_GetMemberBinder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x00037190 File Offset: 0x00035390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 743075, XrefRangeEnd = 743089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DynamicMetaObject FallbackGetMember(DynamicMetaObject target, DynamicMetaObject errorSuggestion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(errorSuggestion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoThrowGetBinderMember.NativeMethodInfoPtr_FallbackGetMember_Public_Virtual_DynamicMetaObject_DynamicMetaObject_DynamicMetaObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x0000462D File Offset: 0x0000282D
		public NoThrowGetBinderMember(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x060007CB RID: 1995 RVA: 0x00037200 File Offset: 0x00035400
		// (set) Token: 0x060007CC RID: 1996 RVA: 0x00004636 File Offset: 0x00002836
		public unsafe GetMemberBinder _innerBinder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoThrowGetBinderMember.NativeFieldInfoPtr__innerBinder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GetMemberBinder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoThrowGetBinderMember.NativeFieldInfoPtr__innerBinder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006CC RID: 1740
		private static readonly IntPtr NativeFieldInfoPtr__innerBinder;

		// Token: 0x040006CD RID: 1741
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GetMemberBinder_0;

		// Token: 0x040006CE RID: 1742
		private static readonly IntPtr NativeMethodInfoPtr_FallbackGetMember_Public_Virtual_DynamicMetaObject_DynamicMetaObject_DynamicMetaObject_0;
	}
}
