using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000231 RID: 561
	[StructLayout(2)]
	public struct DepthState
	{
		// Token: 0x060025B6 RID: 9654 RVA: 0x000A0A00 File Offset: 0x0009EC00
		// Note: this type is marked as 'beforefieldinit'.
		static DepthState()
		{
			Il2CppClassPointerStore<DepthState>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "DepthState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DepthState>.NativeClassPtr);
			DepthState.NativeFieldInfoPtr_m_WriteEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthState>.NativeClassPtr, "m_WriteEnabled");
			DepthState.NativeFieldInfoPtr_m_CompareFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthState>.NativeClassPtr, "m_CompareFunction");
			DepthState.NativeMethodInfoPtr_get_defaultValue_Public_Static_get_DepthState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthState>.NativeClassPtr, 100668144);
			DepthState.NativeMethodInfoPtr__ctor_Public_Void_Boolean_CompareFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthState>.NativeClassPtr, 100668145);
			DepthState.NativeMethodInfoPtr_get_compareFunction_Public_get_CompareFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthState>.NativeClassPtr, 100668146);
			DepthState.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DepthState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthState>.NativeClassPtr, 100668147);
			DepthState.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthState>.NativeClassPtr, 100668148);
			DepthState.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthState>.NativeClassPtr, 100668149);
		}

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x060025B7 RID: 9655 RVA: 0x000A0AD0 File Offset: 0x0009ECD0
		public unsafe static DepthState defaultValue
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 683632, XrefRangeEnd = 683636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthState.NativeMethodInfoPtr_get_defaultValue_Public_Static_get_DepthState_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060025B8 RID: 9656 RVA: 0x000A0B00 File Offset: 0x0009ED00
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 683640, RefRangeEnd = 683643, XrefRangeStart = 683636, XrefRangeEnd = 683640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DepthState(bool writeEnabled = true, CompareFunction compareFunction = CompareFunction.Less)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref writeEnabled;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref compareFunction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthState.NativeMethodInfoPtr__ctor_Public_Void_Boolean_CompareFunction_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x060025B9 RID: 9657 RVA: 0x000A0B40 File Offset: 0x0009ED40
		// (set) Token: 0x060025C0 RID: 9664 RVA: 0x0000EDAA File Offset: 0x0000CFAA
		public unsafe CompareFunction compareFunction
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 683643, RefRangeEnd = 683644, XrefRangeStart = 683643, XrefRangeEnd = 683643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthState.NativeMethodInfoPtr_get_compareFunction_Public_get_CompareFunction_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_CompareFunction = (sbyte)value;
			}
		}

		// Token: 0x060025BA RID: 9658 RVA: 0x000A0B70 File Offset: 0x0009ED70
		[CallerCount(0)]
		public unsafe bool Equals(DepthState other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthState.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DepthState_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060025BB RID: 9659 RVA: 0x000A0BB0 File Offset: 0x0009EDB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 683644, XrefRangeEnd = 683647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthState.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060025BC RID: 9660 RVA: 0x000A0BF4 File Offset: 0x0009EDF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 683647, XrefRangeEnd = 683649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthState.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060025BD RID: 9661 RVA: 0x0000ED89 File Offset: 0x0000CF89
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DepthState>.NativeClassPtr, ref this));
		}

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x060025BE RID: 9662 RVA: 0x000A0C24 File Offset: 0x0009EE24
		// (set) Token: 0x060025BF RID: 9663 RVA: 0x0000ED9B File Offset: 0x0000CF9B
		public bool writeEnabled
		{
			get
			{
				return Convert.ToBoolean(this.m_WriteEnabled);
			}
			set
			{
				this.m_WriteEnabled = Convert.ToByte(value);
			}
		}

		// Token: 0x060025C1 RID: 9665 RVA: 0x000A0C44 File Offset: 0x0009EE44
		public static bool operator ==(DepthState left, DepthState right)
		{
			return left.Equals(right);
		}

		// Token: 0x060025C2 RID: 9666 RVA: 0x000A0C60 File Offset: 0x0009EE60
		public static bool operator !=(DepthState left, DepthState right)
		{
			return !left.Equals(right);
		}

		// Token: 0x040021A8 RID: 8616
		private static readonly IntPtr NativeFieldInfoPtr_m_WriteEnabled;

		// Token: 0x040021A9 RID: 8617
		private static readonly IntPtr NativeFieldInfoPtr_m_CompareFunction;

		// Token: 0x040021AA RID: 8618
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultValue_Public_Static_get_DepthState_0;

		// Token: 0x040021AB RID: 8619
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_CompareFunction_0;

		// Token: 0x040021AC RID: 8620
		private static readonly IntPtr NativeMethodInfoPtr_get_compareFunction_Public_get_CompareFunction_0;

		// Token: 0x040021AD RID: 8621
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DepthState_0;

		// Token: 0x040021AE RID: 8622
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040021AF RID: 8623
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040021B0 RID: 8624
		[FieldOffset(0)]
		public byte m_WriteEnabled;

		// Token: 0x040021B1 RID: 8625
		[FieldOffset(1)]
		public sbyte m_CompareFunction;
	}
}
