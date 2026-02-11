using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.TextCore.Text
{
	// Token: 0x02000029 RID: 41
	[StructLayout(2)]
	public struct Offset
	{
		// Token: 0x06000452 RID: 1106 RVA: 0x00013308 File Offset: 0x00011508
		// Note: this type is marked as 'beforefieldinit'.
		static Offset()
		{
			Il2CppClassPointerStore<Offset>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "Offset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Offset>.NativeClassPtr);
			Offset.NativeFieldInfoPtr_m_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Offset>.NativeClassPtr, "m_Left");
			Offset.NativeFieldInfoPtr_m_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Offset>.NativeClassPtr, "m_Right");
			Offset.NativeFieldInfoPtr_m_Top = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Offset>.NativeClassPtr, "m_Top");
			Offset.NativeFieldInfoPtr_m_Bottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Offset>.NativeClassPtr, "m_Bottom");
			Offset.NativeFieldInfoPtr_k_ZeroOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Offset>.NativeClassPtr, "k_ZeroOffset");
			Offset.NativeMethodInfoPtr_get_left_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Offset>.NativeClassPtr, 100663584);
			Offset.NativeMethodInfoPtr_get_right_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Offset>.NativeClassPtr, 100663585);
			Offset.NativeMethodInfoPtr_get_top_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Offset>.NativeClassPtr, 100663586);
			Offset.NativeMethodInfoPtr_get_bottom_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Offset>.NativeClassPtr, 100663587);
			Offset.NativeMethodInfoPtr_get_zero_Public_Static_get_Offset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Offset>.NativeClassPtr, 100663588);
			Offset.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Offset>.NativeClassPtr, 100663589);
			Offset.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Offset_Offset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Offset>.NativeClassPtr, 100663590);
			Offset.NativeMethodInfoPtr_op_Multiply_Public_Static_Offset_Offset_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Offset>.NativeClassPtr, 100663591);
			Offset.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Offset>.NativeClassPtr, 100663592);
			Offset.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Offset>.NativeClassPtr, 100663593);
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000453 RID: 1107 RVA: 0x00013464 File Offset: 0x00011664
		// (set) Token: 0x06000460 RID: 1120 RVA: 0x00004C37 File Offset: 0x00002E37
		public unsafe float left
		{
			[CallerCount(58)]
			[CachedScanResults(RefRangeStart = 283150, RefRangeEnd = 283208, XrefRangeStart = 283150, XrefRangeEnd = 283208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Offset.NativeMethodInfoPtr_get_left_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Left = value;
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06000454 RID: 1108 RVA: 0x00013494 File Offset: 0x00011694
		// (set) Token: 0x06000461 RID: 1121 RVA: 0x00004C41 File Offset: 0x00002E41
		public unsafe float right
		{
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 644349, RefRangeEnd = 644397, XrefRangeStart = 644349, XrefRangeEnd = 644397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Offset.NativeMethodInfoPtr_get_right_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Right = value;
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000455 RID: 1109 RVA: 0x000134C4 File Offset: 0x000116C4
		// (set) Token: 0x06000462 RID: 1122 RVA: 0x00004C4B File Offset: 0x00002E4B
		public unsafe float top
		{
			[CallerCount(26)]
			[CachedScanResults(RefRangeStart = 644403, RefRangeEnd = 644429, XrefRangeStart = 644403, XrefRangeEnd = 644429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Offset.NativeMethodInfoPtr_get_top_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Top = value;
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000456 RID: 1110 RVA: 0x000134F4 File Offset: 0x000116F4
		// (set) Token: 0x06000463 RID: 1123 RVA: 0x00004C55 File Offset: 0x00002E55
		public unsafe float bottom
		{
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 644431, RefRangeEnd = 644456, XrefRangeStart = 644431, XrefRangeEnd = 644456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Offset.NativeMethodInfoPtr_get_bottom_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Bottom = value;
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000457 RID: 1111 RVA: 0x00013524 File Offset: 0x00011724
		public unsafe static Offset zero
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1104532, RefRangeEnd = 1104535, XrefRangeStart = 1104528, XrefRangeEnd = 1104532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Offset.NativeMethodInfoPtr_get_zero_Public_Static_get_Offset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x00013554 File Offset: 0x00011754
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 323501, RefRangeEnd = 323508, XrefRangeStart = 323501, XrefRangeEnd = 323508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Offset(float left, float right, float top, float bottom)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref left;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref top;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bottom;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Offset.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x000135B0 File Offset: 0x000117B0
		[CallerCount(0)]
		public unsafe static bool operator ==(Offset lhs, Offset rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Offset.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Offset_Offset_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x000135FC File Offset: 0x000117FC
		[CallerCount(0)]
		public unsafe static Offset operator *(Offset a, float b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Offset.NativeMethodInfoPtr_op_Multiply_Public_Static_Offset_Offset_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x00013648 File Offset: 0x00011848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1104535, XrefRangeEnd = 1104539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Offset.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x00013678 File Offset: 0x00011878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1104539, XrefRangeEnd = 1104543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Offset.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x00004C17 File Offset: 0x00002E17
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Offset>.NativeClassPtr, ref this));
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x0600045E RID: 1118 RVA: 0x000136BC File Offset: 0x000118BC
		// (set) Token: 0x0600045F RID: 1119 RVA: 0x00004C29 File Offset: 0x00002E29
		public unsafe static Offset k_ZeroOffset
		{
			get
			{
				Offset offset;
				IL2CPP.il2cpp_field_static_get_value(Offset.NativeFieldInfoPtr_k_ZeroOffset, (void*)(&offset));
				return offset;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Offset.NativeFieldInfoPtr_k_ZeroOffset, (void*)(&value));
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000464 RID: 1124 RVA: 0x000136D8 File Offset: 0x000118D8
		// (set) Token: 0x06000465 RID: 1125 RVA: 0x00004C5F File Offset: 0x00002E5F
		public float horizontal
		{
			get
			{
				return this.m_Left;
			}
			set
			{
				this.m_Left = value;
				this.m_Right = value;
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000466 RID: 1126 RVA: 0x000136F0 File Offset: 0x000118F0
		// (set) Token: 0x06000467 RID: 1127 RVA: 0x00004C70 File Offset: 0x00002E70
		public float vertical
		{
			get
			{
				return this.m_Top;
			}
			set
			{
				this.m_Top = value;
				this.m_Bottom = value;
			}
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x00013708 File Offset: 0x00011908
		public static bool operator !=(Offset lhs, Offset rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x00013724 File Offset: 0x00011924
		public bool Equals(Offset other)
		{
			return base.Equals(other);
		}

		// Token: 0x04000357 RID: 855
		private static readonly IntPtr NativeFieldInfoPtr_m_Left;

		// Token: 0x04000358 RID: 856
		private static readonly IntPtr NativeFieldInfoPtr_m_Right;

		// Token: 0x04000359 RID: 857
		private static readonly IntPtr NativeFieldInfoPtr_m_Top;

		// Token: 0x0400035A RID: 858
		private static readonly IntPtr NativeFieldInfoPtr_m_Bottom;

		// Token: 0x0400035B RID: 859
		private static readonly IntPtr NativeFieldInfoPtr_k_ZeroOffset;

		// Token: 0x0400035C RID: 860
		private static readonly IntPtr NativeMethodInfoPtr_get_left_Public_get_Single_0;

		// Token: 0x0400035D RID: 861
		private static readonly IntPtr NativeMethodInfoPtr_get_right_Public_get_Single_0;

		// Token: 0x0400035E RID: 862
		private static readonly IntPtr NativeMethodInfoPtr_get_top_Public_get_Single_0;

		// Token: 0x0400035F RID: 863
		private static readonly IntPtr NativeMethodInfoPtr_get_bottom_Public_get_Single_0;

		// Token: 0x04000360 RID: 864
		private static readonly IntPtr NativeMethodInfoPtr_get_zero_Public_Static_get_Offset_0;

		// Token: 0x04000361 RID: 865
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0;

		// Token: 0x04000362 RID: 866
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Offset_Offset_0;

		// Token: 0x04000363 RID: 867
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Offset_Offset_Single_0;

		// Token: 0x04000364 RID: 868
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000365 RID: 869
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000366 RID: 870
		[FieldOffset(0)]
		public float m_Left;

		// Token: 0x04000367 RID: 871
		[FieldOffset(4)]
		public float m_Right;

		// Token: 0x04000368 RID: 872
		[FieldOffset(8)]
		public float m_Top;

		// Token: 0x04000369 RID: 873
		[FieldOffset(12)]
		public float m_Bottom;
	}
}
