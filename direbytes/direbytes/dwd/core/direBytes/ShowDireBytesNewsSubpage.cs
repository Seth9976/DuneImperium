using System;
using dwd.core.direBytes.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace dwd.core.direBytes
{
	// Token: 0x02000013 RID: 19
	public class ShowDireBytesNewsSubpage : ShowDireByteNews
	{
		// Token: 0x060000DA RID: 218 RVA: 0x00005EAC File Offset: 0x000040AC
		// Note: this type is marked as 'beforefieldinit'.
		static ShowDireBytesNewsSubpage()
		{
			Il2CppClassPointerStore<ShowDireBytesNewsSubpage>.NativeClassPtr = IL2CPP.GetIl2CppClass("direbytes.dll", "dwd.core.direBytes", "ShowDireBytesNewsSubpage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowDireBytesNewsSubpage>.NativeClassPtr);
			ShowDireBytesNewsSubpage.NativeFieldInfoPtr_subpage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowDireBytesNewsSubpage>.NativeClassPtr, "subpage");
			ShowDireBytesNewsSubpage.NativeFieldInfoPtr_subpageAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowDireBytesNewsSubpage>.NativeClassPtr, "subpageAnim");
			ShowDireBytesNewsSubpage.NativeFieldInfoPtr_subpageParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowDireBytesNewsSubpage>.NativeClassPtr, "subpageParam");
			ShowDireBytesNewsSubpage.NativeMethodInfoPtr_preventShowing_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowDireBytesNewsSubpage>.NativeClassPtr, 100663409);
			ShowDireBytesNewsSubpage.NativeMethodInfoPtr_showSubpage_Protected_Virtual_Void_DireByteTileNewsSubpageData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowDireBytesNewsSubpage>.NativeClassPtr, 100663410);
			ShowDireBytesNewsSubpage.NativeMethodInfoPtr_hideSubpage_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowDireBytesNewsSubpage>.NativeClassPtr, 100663411);
			ShowDireBytesNewsSubpage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowDireBytesNewsSubpage>.NativeClassPtr, 100663412);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00005F68 File Offset: 0x00004168
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool preventShowing()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShowDireBytesNewsSubpage.NativeMethodInfoPtr_preventShowing_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00005FB0 File Offset: 0x000041B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234871, XrefRangeEnd = 1234895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void showSubpage(DireByteTileNewsSubpageData subpageData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(subpageData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShowDireBytesNewsSubpage.NativeMethodInfoPtr_showSubpage_Protected_Virtual_Void_DireByteTileNewsSubpageData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00006000 File Offset: 0x00004200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234895, XrefRangeEnd = 1234904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void hideSubpage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShowDireBytesNewsSubpage.NativeMethodInfoPtr_hideSubpage_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0000603C File Offset: 0x0000423C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234904, XrefRangeEnd = 1234909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShowDireBytesNewsSubpage()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShowDireBytesNewsSubpage>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowDireBytesNewsSubpage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x0000269E File Offset: 0x0000089E
		public ShowDireBytesNewsSubpage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x00006078 File Offset: 0x00004278
		// (set) Token: 0x060000E1 RID: 225 RVA: 0x000026A7 File Offset: 0x000008A7
		public unsafe SubscriptionProvider subpage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowDireBytesNewsSubpage.NativeFieldInfoPtr_subpage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubscriptionProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowDireBytesNewsSubpage.NativeFieldInfoPtr_subpage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x000060A8 File Offset: 0x000042A8
		// (set) Token: 0x060000E3 RID: 227 RVA: 0x000026C6 File Offset: 0x000008C6
		public unsafe Animator subpageAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowDireBytesNewsSubpage.NativeFieldInfoPtr_subpageAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowDireBytesNewsSubpage.NativeFieldInfoPtr_subpageAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x000060D8 File Offset: 0x000042D8
		// (set) Token: 0x060000E5 RID: 229 RVA: 0x000026E5 File Offset: 0x000008E5
		public unsafe string subpageParam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowDireBytesNewsSubpage.NativeFieldInfoPtr_subpageParam);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowDireBytesNewsSubpage.NativeFieldInfoPtr_subpageParam), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeFieldInfoPtr_subpage;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeFieldInfoPtr_subpageAnim;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeFieldInfoPtr_subpageParam;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr_preventShowing_Protected_Virtual_Boolean_0;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr_showSubpage_Protected_Virtual_Void_DireByteTileNewsSubpageData_0;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeMethodInfoPtr_hideSubpage_Protected_Virtual_Void_0;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
