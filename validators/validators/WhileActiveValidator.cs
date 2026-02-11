using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace validators
{
	// Token: 0x02000019 RID: 25
	public class WhileActiveValidator : MonoBehaviour
	{
		// Token: 0x060000CD RID: 205 RVA: 0x00004F08 File Offset: 0x00003108
		// Note: this type is marked as 'beforefieldinit'.
		static WhileActiveValidator()
		{
			Il2CppClassPointerStore<WhileActiveValidator>.NativeClassPtr = IL2CPP.GetIl2CppClass("validators.dll", "validators", "WhileActiveValidator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WhileActiveValidator>.NativeClassPtr);
			WhileActiveValidator.NativeFieldInfoPtr_activeObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WhileActiveValidator>.NativeClassPtr, "activeObject");
			WhileActiveValidator.NativeFieldInfoPtr_validWhenDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WhileActiveValidator>.NativeClassPtr, "validWhenDisabled");
			WhileActiveValidator.NativeFieldInfoPtr__Valid_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WhileActiveValidator>.NativeClassPtr, "<Valid>k__BackingField");
			WhileActiveValidator.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WhileActiveValidator>.NativeClassPtr, 100663381);
			WhileActiveValidator.NativeMethodInfoPtr_get_Valid_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WhileActiveValidator>.NativeClassPtr, 100663382);
			WhileActiveValidator.NativeMethodInfoPtr_set_Valid_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WhileActiveValidator>.NativeClassPtr, 100663383);
			WhileActiveValidator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WhileActiveValidator>.NativeClassPtr, 100663384);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00004FC4 File Offset: 0x000031C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267784, XrefRangeEnd = 1267785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WhileActiveValidator.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000CF RID: 207 RVA: 0x00004FF8 File Offset: 0x000031F8
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x00005034 File Offset: 0x00003234
		public unsafe virtual bool Valid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WhileActiveValidator.NativeMethodInfoPtr_get_Valid_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WhileActiveValidator.NativeMethodInfoPtr_set_Valid_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00005074 File Offset: 0x00003274
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WhileActiveValidator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WhileActiveValidator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WhileActiveValidator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00002601 File Offset: 0x00000801
		public WhileActiveValidator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x000050B0 File Offset: 0x000032B0
		// (set) Token: 0x060000D4 RID: 212 RVA: 0x0000260A File Offset: 0x0000080A
		public unsafe GameObject activeObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WhileActiveValidator.NativeFieldInfoPtr_activeObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WhileActiveValidator.NativeFieldInfoPtr_activeObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x000050E0 File Offset: 0x000032E0
		// (set) Token: 0x060000D6 RID: 214 RVA: 0x00002629 File Offset: 0x00000829
		public unsafe bool validWhenDisabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WhileActiveValidator.NativeFieldInfoPtr_validWhenDisabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WhileActiveValidator.NativeFieldInfoPtr_validWhenDisabled)) = value;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x00005108 File Offset: 0x00003308
		// (set) Token: 0x060000D8 RID: 216 RVA: 0x00002644 File Offset: 0x00000844
		public unsafe bool _Valid_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WhileActiveValidator.NativeFieldInfoPtr__Valid_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WhileActiveValidator.NativeFieldInfoPtr__Valid_k__BackingField)) = value;
			}
		}

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeFieldInfoPtr_activeObject;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeFieldInfoPtr_validWhenDisabled;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeFieldInfoPtr__Valid_k__BackingField;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeMethodInfoPtr_get_Valid_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr_set_Valid_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
