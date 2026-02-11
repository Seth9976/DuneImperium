using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020001CD RID: 461
	[Serializable]
	[StructLayout(2)]
	public struct StyleValueHandle
	{
		// Token: 0x0600241B RID: 9243 RVA: 0x000A2440 File Offset: 0x000A0640
		// Note: this type is marked as 'beforefieldinit'.
		static StyleValueHandle()
		{
			Il2CppClassPointerStore<StyleValueHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "StyleValueHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleValueHandle>.NativeClassPtr);
			StyleValueHandle.NativeFieldInfoPtr_m_ValueType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleValueHandle>.NativeClassPtr, "m_ValueType");
			StyleValueHandle.NativeFieldInfoPtr_valueIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleValueHandle>.NativeClassPtr, "valueIndex");
			StyleValueHandle.NativeMethodInfoPtr_get_valueType_Public_get_StyleValueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleValueHandle>.NativeClassPtr, 100668778);
			StyleValueHandle.NativeMethodInfoPtr_set_valueType_Internal_set_Void_StyleValueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleValueHandle>.NativeClassPtr, 100668779);
		}

		// Token: 0x17000B59 RID: 2905
		// (get) Token: 0x0600241C RID: 9244 RVA: 0x000A24C0 File Offset: 0x000A06C0
		// (set) Token: 0x0600241D RID: 9245 RVA: 0x000A24F0 File Offset: 0x000A06F0
		public unsafe StyleValueType valueType
		{
			[CallerCount(236)]
			[CachedScanResults(RefRangeStart = 283634, RefRangeEnd = 283870, XrefRangeStart = 283634, XrefRangeEnd = 283870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleValueHandle.NativeMethodInfoPtr_get_valueType_Public_get_StyleValueType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 320163, RefRangeEnd = 320170, XrefRangeStart = 320163, XrefRangeEnd = 320170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleValueHandle.NativeMethodInfoPtr_set_valueType_Internal_set_Void_StyleValueType_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600241E RID: 9246 RVA: 0x0000ED52 File Offset: 0x0000CF52
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StyleValueHandle>.NativeClassPtr, ref this));
		}

		// Token: 0x040019E5 RID: 6629
		private static readonly IntPtr NativeFieldInfoPtr_m_ValueType;

		// Token: 0x040019E6 RID: 6630
		private static readonly IntPtr NativeFieldInfoPtr_valueIndex;

		// Token: 0x040019E7 RID: 6631
		private static readonly IntPtr NativeMethodInfoPtr_get_valueType_Public_get_StyleValueType_0;

		// Token: 0x040019E8 RID: 6632
		private static readonly IntPtr NativeMethodInfoPtr_set_valueType_Internal_set_Void_StyleValueType_0;

		// Token: 0x040019E9 RID: 6633
		[FieldOffset(0)]
		public StyleValueType m_ValueType;

		// Token: 0x040019EA RID: 6634
		[FieldOffset(4)]
		public int valueIndex;
	}
}
