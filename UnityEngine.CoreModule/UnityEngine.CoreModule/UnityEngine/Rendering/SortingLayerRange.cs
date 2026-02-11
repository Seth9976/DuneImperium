using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x0200024B RID: 587
	[StructLayout(2)]
	public struct SortingLayerRange
	{
		// Token: 0x060027AA RID: 10154 RVA: 0x000A73D4 File Offset: 0x000A55D4
		// Note: this type is marked as 'beforefieldinit'.
		static SortingLayerRange()
		{
			Il2CppClassPointerStore<SortingLayerRange>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "SortingLayerRange");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortingLayerRange>.NativeClassPtr);
			SortingLayerRange.NativeFieldInfoPtr_m_LowerBound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortingLayerRange>.NativeClassPtr, "m_LowerBound");
			SortingLayerRange.NativeFieldInfoPtr_m_UpperBound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortingLayerRange>.NativeClassPtr, "m_UpperBound");
			SortingLayerRange.NativeMethodInfoPtr__ctor_Public_Void_Int16_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingLayerRange>.NativeClassPtr, 100668384);
			SortingLayerRange.NativeMethodInfoPtr_get_lowerBound_Public_get_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingLayerRange>.NativeClassPtr, 100668385);
			SortingLayerRange.NativeMethodInfoPtr_get_upperBound_Public_get_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingLayerRange>.NativeClassPtr, 100668386);
			SortingLayerRange.NativeMethodInfoPtr_get_all_Public_Static_get_SortingLayerRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingLayerRange>.NativeClassPtr, 100668387);
			SortingLayerRange.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SortingLayerRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingLayerRange>.NativeClassPtr, 100668388);
			SortingLayerRange.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingLayerRange>.NativeClassPtr, 100668389);
			SortingLayerRange.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingLayerRange>.NativeClassPtr, 100668390);
		}

		// Token: 0x060027AB RID: 10155 RVA: 0x000A74B8 File Offset: 0x000A56B8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 438691, RefRangeEnd = 438696, XrefRangeStart = 438691, XrefRangeEnd = 438696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SortingLayerRange(short lowerBound, short upperBound)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lowerBound;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref upperBound;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingLayerRange.NativeMethodInfoPtr__ctor_Public_Void_Int16_Int16_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x060027AC RID: 10156 RVA: 0x000A74F8 File Offset: 0x000A56F8
		// (set) Token: 0x060027B3 RID: 10163 RVA: 0x0000F61E File Offset: 0x0000D81E
		public unsafe short lowerBound
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 685034, RefRangeEnd = 685035, XrefRangeStart = 685034, XrefRangeEnd = 685034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingLayerRange.NativeMethodInfoPtr_get_lowerBound_Public_get_Int16_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_LowerBound = value;
			}
		}

		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x060027AD RID: 10157 RVA: 0x000A7528 File Offset: 0x000A5728
		// (set) Token: 0x060027B4 RID: 10164 RVA: 0x0000F628 File Offset: 0x0000D828
		public unsafe short upperBound
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 685035, RefRangeEnd = 685036, XrefRangeStart = 685035, XrefRangeEnd = 685035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingLayerRange.NativeMethodInfoPtr_get_upperBound_Public_get_Int16_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_UpperBound = value;
			}
		}

		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x060027AE RID: 10158 RVA: 0x000A7558 File Offset: 0x000A5758
		public unsafe static SortingLayerRange all
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 685036, RefRangeEnd = 685038, XrefRangeStart = 685036, XrefRangeEnd = 685036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingLayerRange.NativeMethodInfoPtr_get_all_Public_Static_get_SortingLayerRange_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060027AF RID: 10159 RVA: 0x000A7588 File Offset: 0x000A5788
		[CallerCount(0)]
		public unsafe bool Equals(SortingLayerRange other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingLayerRange.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SortingLayerRange_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060027B0 RID: 10160 RVA: 0x000A75C8 File Offset: 0x000A57C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 685038, XrefRangeEnd = 685041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingLayerRange.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060027B1 RID: 10161 RVA: 0x000A760C File Offset: 0x000A580C
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingLayerRange.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060027B2 RID: 10162 RVA: 0x0000F60C File Offset: 0x0000D80C
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SortingLayerRange>.NativeClassPtr, ref this));
		}

		// Token: 0x060027B5 RID: 10165 RVA: 0x000A763C File Offset: 0x000A583C
		public static bool operator !=(SortingLayerRange lhs, SortingLayerRange rhs)
		{
			return !lhs.Equals(rhs);
		}

		// Token: 0x060027B6 RID: 10166 RVA: 0x000A765C File Offset: 0x000A585C
		public static bool operator ==(SortingLayerRange lhs, SortingLayerRange rhs)
		{
			return lhs.Equals(rhs);
		}

		// Token: 0x0400236A RID: 9066
		private static readonly IntPtr NativeFieldInfoPtr_m_LowerBound;

		// Token: 0x0400236B RID: 9067
		private static readonly IntPtr NativeFieldInfoPtr_m_UpperBound;

		// Token: 0x0400236C RID: 9068
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int16_Int16_0;

		// Token: 0x0400236D RID: 9069
		private static readonly IntPtr NativeMethodInfoPtr_get_lowerBound_Public_get_Int16_0;

		// Token: 0x0400236E RID: 9070
		private static readonly IntPtr NativeMethodInfoPtr_get_upperBound_Public_get_Int16_0;

		// Token: 0x0400236F RID: 9071
		private static readonly IntPtr NativeMethodInfoPtr_get_all_Public_Static_get_SortingLayerRange_0;

		// Token: 0x04002370 RID: 9072
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SortingLayerRange_0;

		// Token: 0x04002371 RID: 9073
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002372 RID: 9074
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002373 RID: 9075
		[FieldOffset(0)]
		public short m_LowerBound;

		// Token: 0x04002374 RID: 9076
		[FieldOffset(2)]
		public short m_UpperBound;
	}
}
