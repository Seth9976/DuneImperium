using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace validators
{
	// Token: 0x0200001A RID: 26
	public class WhileEnabledValidator : MonoBehaviour
	{
		// Token: 0x060000D9 RID: 217 RVA: 0x00005130 File Offset: 0x00003330
		// Note: this type is marked as 'beforefieldinit'.
		static WhileEnabledValidator()
		{
			Il2CppClassPointerStore<WhileEnabledValidator>.NativeClassPtr = IL2CPP.GetIl2CppClass("validators.dll", "validators", "WhileEnabledValidator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WhileEnabledValidator>.NativeClassPtr);
			WhileEnabledValidator.NativeFieldInfoPtr_activeObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WhileEnabledValidator>.NativeClassPtr, "activeObject");
			WhileEnabledValidator.NativeFieldInfoPtr_validWhenDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WhileEnabledValidator>.NativeClassPtr, "validWhenDisabled");
			WhileEnabledValidator.NativeFieldInfoPtr__Valid_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WhileEnabledValidator>.NativeClassPtr, "<Valid>k__BackingField");
			WhileEnabledValidator.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WhileEnabledValidator>.NativeClassPtr, 100663385);
			WhileEnabledValidator.NativeMethodInfoPtr_get_Valid_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WhileEnabledValidator>.NativeClassPtr, 100663386);
			WhileEnabledValidator.NativeMethodInfoPtr_set_Valid_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WhileEnabledValidator>.NativeClassPtr, 100663387);
			WhileEnabledValidator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WhileEnabledValidator>.NativeClassPtr, 100663388);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x000051EC File Offset: 0x000033EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267785, XrefRangeEnd = 1267786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WhileEnabledValidator.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000DB RID: 219 RVA: 0x00005220 File Offset: 0x00003420
		// (set) Token: 0x060000DC RID: 220 RVA: 0x0000525C File Offset: 0x0000345C
		public unsafe virtual bool Valid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WhileEnabledValidator.NativeMethodInfoPtr_get_Valid_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WhileEnabledValidator.NativeMethodInfoPtr_set_Valid_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000DD RID: 221 RVA: 0x0000529C File Offset: 0x0000349C
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WhileEnabledValidator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WhileEnabledValidator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WhileEnabledValidator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0000265F File Offset: 0x0000085F
		public WhileEnabledValidator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000DF RID: 223 RVA: 0x000052D8 File Offset: 0x000034D8
		// (set) Token: 0x060000E0 RID: 224 RVA: 0x00002668 File Offset: 0x00000868
		public unsafe MonoBehaviour activeObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WhileEnabledValidator.NativeFieldInfoPtr_activeObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WhileEnabledValidator.NativeFieldInfoPtr_activeObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x00005308 File Offset: 0x00003508
		// (set) Token: 0x060000E2 RID: 226 RVA: 0x00002687 File Offset: 0x00000887
		public unsafe bool validWhenDisabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WhileEnabledValidator.NativeFieldInfoPtr_validWhenDisabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WhileEnabledValidator.NativeFieldInfoPtr_validWhenDisabled)) = value;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x00005330 File Offset: 0x00003530
		// (set) Token: 0x060000E4 RID: 228 RVA: 0x000026A2 File Offset: 0x000008A2
		public unsafe bool _Valid_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WhileEnabledValidator.NativeFieldInfoPtr__Valid_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WhileEnabledValidator.NativeFieldInfoPtr__Valid_k__BackingField)) = value;
			}
		}

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeFieldInfoPtr_activeObject;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeFieldInfoPtr_validWhenDisabled;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeFieldInfoPtr__Valid_k__BackingField;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr_get_Valid_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeMethodInfoPtr_set_Valid_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
