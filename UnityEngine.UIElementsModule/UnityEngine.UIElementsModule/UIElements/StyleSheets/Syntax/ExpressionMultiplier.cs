using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements.StyleSheets.Syntax
{
	// Token: 0x0200029A RID: 666
	[StructLayout(2)]
	public struct ExpressionMultiplier
	{
		// Token: 0x06003143 RID: 12611 RVA: 0x000D104C File Offset: 0x000CF24C
		// Note: this type is marked as 'beforefieldinit'.
		static ExpressionMultiplier()
		{
			Il2CppClassPointerStore<ExpressionMultiplier>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.StyleSheets.Syntax", "ExpressionMultiplier");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExpressionMultiplier>.NativeClassPtr);
			ExpressionMultiplier.NativeFieldInfoPtr_Infinity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionMultiplier>.NativeClassPtr, "Infinity");
			ExpressionMultiplier.NativeFieldInfoPtr_m_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionMultiplier>.NativeClassPtr, "m_Type");
			ExpressionMultiplier.NativeFieldInfoPtr_min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionMultiplier>.NativeClassPtr, "min");
			ExpressionMultiplier.NativeFieldInfoPtr_max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionMultiplier>.NativeClassPtr, "max");
			ExpressionMultiplier.NativeMethodInfoPtr_get_type_Public_get_ExpressionMultiplierType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionMultiplier>.NativeClassPtr, 100670446);
			ExpressionMultiplier.NativeMethodInfoPtr_set_type_Public_set_Void_ExpressionMultiplierType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionMultiplier>.NativeClassPtr, 100670447);
			ExpressionMultiplier.NativeMethodInfoPtr__ctor_Public_Void_ExpressionMultiplierType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionMultiplier>.NativeClassPtr, 100670448);
			ExpressionMultiplier.NativeMethodInfoPtr_SetType_Private_Void_ExpressionMultiplierType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionMultiplier>.NativeClassPtr, 100670449);
		}

		// Token: 0x17000F7A RID: 3962
		// (get) Token: 0x06003144 RID: 12612 RVA: 0x000D111C File Offset: 0x000CF31C
		// (set) Token: 0x06003145 RID: 12613 RVA: 0x000D114C File Offset: 0x000CF34C
		public unsafe ExpressionMultiplierType type
		{
			[CallerCount(236)]
			[CachedScanResults(RefRangeStart = 283634, RefRangeEnd = 283870, XrefRangeStart = 283634, XrefRangeEnd = 283870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionMultiplier.NativeMethodInfoPtr_get_type_Public_get_ExpressionMultiplierType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358934, XrefRangeEnd = 358935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionMultiplier.NativeMethodInfoPtr_set_type_Public_set_Void_ExpressionMultiplierType_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003146 RID: 12614 RVA: 0x000D1180 File Offset: 0x000CF380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358935, XrefRangeEnd = 358936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExpressionMultiplier(ExpressionMultiplierType type = ExpressionMultiplierType.None)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionMultiplier.NativeMethodInfoPtr__ctor_Public_Void_ExpressionMultiplierType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003147 RID: 12615 RVA: 0x000D11B4 File Offset: 0x000CF3B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 358936, RefRangeEnd = 358938, XrefRangeStart = 358936, XrefRangeEnd = 358936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetType(ExpressionMultiplierType value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionMultiplier.NativeMethodInfoPtr_SetType_Private_Void_ExpressionMultiplierType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003148 RID: 12616 RVA: 0x0001416C File Offset: 0x0001236C
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ExpressionMultiplier>.NativeClassPtr, ref this));
		}

		// Token: 0x17000F79 RID: 3961
		// (get) Token: 0x06003149 RID: 12617 RVA: 0x000D11E8 File Offset: 0x000CF3E8
		// (set) Token: 0x0600314A RID: 12618 RVA: 0x0001417E File Offset: 0x0001237E
		public unsafe static int Infinity
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ExpressionMultiplier.NativeFieldInfoPtr_Infinity, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExpressionMultiplier.NativeFieldInfoPtr_Infinity, (void*)(&value));
			}
		}

		// Token: 0x04002425 RID: 9253
		private static readonly IntPtr NativeFieldInfoPtr_Infinity;

		// Token: 0x04002426 RID: 9254
		private static readonly IntPtr NativeFieldInfoPtr_m_Type;

		// Token: 0x04002427 RID: 9255
		private static readonly IntPtr NativeFieldInfoPtr_min;

		// Token: 0x04002428 RID: 9256
		private static readonly IntPtr NativeFieldInfoPtr_max;

		// Token: 0x04002429 RID: 9257
		private static readonly IntPtr NativeMethodInfoPtr_get_type_Public_get_ExpressionMultiplierType_0;

		// Token: 0x0400242A RID: 9258
		private static readonly IntPtr NativeMethodInfoPtr_set_type_Public_set_Void_ExpressionMultiplierType_0;

		// Token: 0x0400242B RID: 9259
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ExpressionMultiplierType_0;

		// Token: 0x0400242C RID: 9260
		private static readonly IntPtr NativeMethodInfoPtr_SetType_Private_Void_ExpressionMultiplierType_0;

		// Token: 0x0400242D RID: 9261
		[FieldOffset(0)]
		public ExpressionMultiplierType m_Type;

		// Token: 0x0400242E RID: 9262
		[FieldOffset(4)]
		public int min;

		// Token: 0x0400242F RID: 9263
		[FieldOffset(8)]
		public int max;
	}
}
