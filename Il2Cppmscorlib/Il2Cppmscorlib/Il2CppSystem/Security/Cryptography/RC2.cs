using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000252 RID: 594
	public class RC2 : SymmetricAlgorithm
	{
		// Token: 0x06002677 RID: 9847 RVA: 0x000D2C78 File Offset: 0x000D0E78
		// Note: this type is marked as 'beforefieldinit'.
		static RC2()
		{
			Il2CppClassPointerStore<RC2>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "RC2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RC2>.NativeClassPtr);
			RC2.NativeFieldInfoPtr_EffectiveKeySizeValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RC2>.NativeClassPtr, "EffectiveKeySizeValue");
			RC2.NativeFieldInfoPtr_s_legalBlockSizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RC2>.NativeClassPtr, "s_legalBlockSizes");
			RC2.NativeFieldInfoPtr_s_legalKeySizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RC2>.NativeClassPtr, "s_legalKeySizes");
			RC2.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RC2>.NativeClassPtr, 100669698);
			RC2.NativeMethodInfoPtr_get_EffectiveKeySize_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RC2>.NativeClassPtr, 100669699);
			RC2.NativeMethodInfoPtr_get_KeySize_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RC2>.NativeClassPtr, 100669700);
			RC2.NativeMethodInfoPtr_set_KeySize_Public_Virtual_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RC2>.NativeClassPtr, 100669701);
		}

		// Token: 0x06002678 RID: 9848 RVA: 0x000D2D34 File Offset: 0x000D0F34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1372518, XrefRangeEnd = 1372526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RC2()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RC2>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RC2.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x06002679 RID: 9849 RVA: 0x000D2D70 File Offset: 0x000D0F70
		public unsafe virtual int EffectiveKeySize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RC2.NativeMethodInfoPtr_get_EffectiveKeySize_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x0600267A RID: 9850 RVA: 0x000D2DB8 File Offset: 0x000D0FB8
		// (set) Token: 0x0600267B RID: 9851 RVA: 0x000D2E00 File Offset: 0x000D1000
		public unsafe override int KeySize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RC2.NativeMethodInfoPtr_get_KeySize_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1372526, XrefRangeEnd = 1372534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RC2.NativeMethodInfoPtr_set_KeySize_Public_Virtual_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600267C RID: 9852 RVA: 0x0000C7AA File Offset: 0x0000A9AA
		public RC2(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x0600267D RID: 9853 RVA: 0x000D2E4C File Offset: 0x000D104C
		// (set) Token: 0x0600267E RID: 9854 RVA: 0x0000C7B3 File Offset: 0x0000A9B3
		public unsafe int EffectiveKeySizeValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RC2.NativeFieldInfoPtr_EffectiveKeySizeValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RC2.NativeFieldInfoPtr_EffectiveKeySizeValue)) = value;
			}
		}

		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x0600267F RID: 9855 RVA: 0x000D2E74 File Offset: 0x000D1074
		// (set) Token: 0x06002680 RID: 9856 RVA: 0x0000C7CE File Offset: 0x0000A9CE
		public unsafe static Il2CppReferenceArray<KeySizes> s_legalBlockSizes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RC2.NativeFieldInfoPtr_s_legalBlockSizes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeySizes>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RC2.NativeFieldInfoPtr_s_legalBlockSizes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x06002681 RID: 9857 RVA: 0x000D2E9C File Offset: 0x000D109C
		// (set) Token: 0x06002682 RID: 9858 RVA: 0x0000C7E0 File Offset: 0x0000A9E0
		public unsafe static Il2CppReferenceArray<KeySizes> s_legalKeySizes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RC2.NativeFieldInfoPtr_s_legalKeySizes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeySizes>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RC2.NativeFieldInfoPtr_s_legalKeySizes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002149 RID: 8521
		private static readonly IntPtr NativeFieldInfoPtr_EffectiveKeySizeValue;

		// Token: 0x0400214A RID: 8522
		private static readonly IntPtr NativeFieldInfoPtr_s_legalBlockSizes;

		// Token: 0x0400214B RID: 8523
		private static readonly IntPtr NativeFieldInfoPtr_s_legalKeySizes;

		// Token: 0x0400214C RID: 8524
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0400214D RID: 8525
		private static readonly IntPtr NativeMethodInfoPtr_get_EffectiveKeySize_Public_Virtual_New_get_Int32_0;

		// Token: 0x0400214E RID: 8526
		private static readonly IntPtr NativeMethodInfoPtr_get_KeySize_Public_Virtual_get_Int32_0;

		// Token: 0x0400214F RID: 8527
		private static readonly IntPtr NativeMethodInfoPtr_set_KeySize_Public_Virtual_set_Void_Int32_0;
	}
}
