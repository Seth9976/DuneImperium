using System;
using boardgames.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;
using UnityEngine;

namespace worm.match.components
{
	// Token: 0x020001C1 RID: 449
	public class ShowGraftEffectValidator : MonoBehaviour
	{
		// Token: 0x060013B7 RID: 5047 RVA: 0x000540A0 File Offset: 0x000522A0
		// Note: this type is marked as 'beforefieldinit'.
		static ShowGraftEffectValidator()
		{
			Il2CppClassPointerStore<ShowGraftEffectValidator>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "ShowGraftEffectValidator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowGraftEffectValidator>.NativeClassPtr);
			ShowGraftEffectValidator.NativeFieldInfoPtr_activeAgentAreaView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowGraftEffectValidator>.NativeClassPtr, "activeAgentAreaView");
			ShowGraftEffectValidator.NativeFieldInfoPtr_selectionResponder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowGraftEffectValidator>.NativeClassPtr, "selectionResponder");
			ShowGraftEffectValidator.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowGraftEffectValidator>.NativeClassPtr, 100666006);
			ShowGraftEffectValidator.NativeMethodInfoPtr_get_Valid_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowGraftEffectValidator>.NativeClassPtr, 100666007);
			ShowGraftEffectValidator.NativeMethodInfoPtr_set_Valid_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowGraftEffectValidator>.NativeClassPtr, 100666008);
			ShowGraftEffectValidator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowGraftEffectValidator>.NativeClassPtr, 100666009);
		}

		// Token: 0x060013B8 RID: 5048 RVA: 0x00054148 File Offset: 0x00052348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713321, XrefRangeEnd = 713324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowGraftEffectValidator.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x060013B9 RID: 5049 RVA: 0x0005417C File Offset: 0x0005237C
		// (set) Token: 0x060013BA RID: 5050 RVA: 0x000541B8 File Offset: 0x000523B8
		public unsafe virtual bool Valid
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713324, XrefRangeEnd = 713328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowGraftEffectValidator.NativeMethodInfoPtr_get_Valid_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowGraftEffectValidator.NativeMethodInfoPtr_set_Valid_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060013BB RID: 5051 RVA: 0x000541F8 File Offset: 0x000523F8
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShowGraftEffectValidator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShowGraftEffectValidator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowGraftEffectValidator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013BC RID: 5052 RVA: 0x0000C209 File Offset: 0x0000A409
		public ShowGraftEffectValidator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x060013BD RID: 5053 RVA: 0x00054234 File Offset: 0x00052434
		// (set) Token: 0x060013BE RID: 5054 RVA: 0x0000C212 File Offset: 0x0000A412
		public unsafe EntityView activeAgentAreaView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowGraftEffectValidator.NativeFieldInfoPtr_activeAgentAreaView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowGraftEffectValidator.NativeFieldInfoPtr_activeAgentAreaView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x060013BF RID: 5055 RVA: 0x00054264 File Offset: 0x00052464
		// (set) Token: 0x060013C0 RID: 5056 RVA: 0x0000C231 File Offset: 0x0000A431
		public unsafe DBGSelectionResponder selectionResponder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowGraftEffectValidator.NativeFieldInfoPtr_selectionResponder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGSelectionResponder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowGraftEffectValidator.NativeFieldInfoPtr_selectionResponder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B6D RID: 2925
		private static readonly IntPtr NativeFieldInfoPtr_activeAgentAreaView;

		// Token: 0x04000B6E RID: 2926
		private static readonly IntPtr NativeFieldInfoPtr_selectionResponder;

		// Token: 0x04000B6F RID: 2927
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000B70 RID: 2928
		private static readonly IntPtr NativeMethodInfoPtr_get_Valid_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000B71 RID: 2929
		private static readonly IntPtr NativeMethodInfoPtr_set_Valid_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04000B72 RID: 2930
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
