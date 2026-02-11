using System;
using Canis.context.propertiesphrases;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.context.contextToList
{
	// Token: 0x02000131 RID: 305
	[Serializable]
	public class ContextToListCount : ContextToInt
	{
		// Token: 0x06000DF1 RID: 3569 RVA: 0x00054B30 File Offset: 0x00052D30
		// Note: this type is marked as 'beforefieldinit'.
		static ContextToListCount()
		{
			Il2CppClassPointerStore<ContextToListCount>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.context.contextToList", "ContextToListCount");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContextToListCount>.NativeClassPtr);
			ContextToListCount.NativeFieldInfoPtr_ctl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContextToListCount>.NativeClassPtr, "ctl");
			ContextToListCount.NativeMethodInfoPtr__ctor_Public_Void_ContextToList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextToListCount>.NativeClassPtr, 100666371);
			ContextToListCount.NativeMethodInfoPtr_Evaluate_Public_Virtual_Int32_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextToListCount>.NativeClassPtr, 100666372);
		}

		// Token: 0x06000DF2 RID: 3570 RVA: 0x00054B9C File Offset: 0x00052D9C
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContextToListCount(ContextToList ctl)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContextToListCount>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ctl);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextToListCount.NativeMethodInfoPtr__ctor_Public_Void_ContextToList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DF3 RID: 3571 RVA: 0x00054BE8 File Offset: 0x00052DE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577107, XrefRangeEnd = 577114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Evaluate(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContextToListCount.NativeMethodInfoPtr_Evaluate_Public_Virtual_Int32_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DF4 RID: 3572 RVA: 0x00007151 File Offset: 0x00005351
		public ContextToListCount(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06000DF5 RID: 3573 RVA: 0x00054C40 File Offset: 0x00052E40
		// (set) Token: 0x06000DF6 RID: 3574 RVA: 0x0000715A File Offset: 0x0000535A
		public unsafe ContextToList ctl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContextToListCount.NativeFieldInfoPtr_ctl);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContextToList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContextToListCount.NativeFieldInfoPtr_ctl), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400097B RID: 2427
		private static readonly IntPtr NativeFieldInfoPtr_ctl;

		// Token: 0x0400097C RID: 2428
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ContextToList_0;

		// Token: 0x0400097D RID: 2429
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Virtual_Int32_Context_0;
	}
}
