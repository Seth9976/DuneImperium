using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000102 RID: 258
	[StructLayout(2)]
	public struct Vector2Int
	{
		// Token: 0x06001537 RID: 5431 RVA: 0x000688F4 File Offset: 0x00066AF4
		// Note: this type is marked as 'beforefieldinit'.
		static Vector2Int()
		{
			Il2CppClassPointerStore<Vector2Int>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Vector2Int");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr);
			Vector2Int.NativeFieldInfoPtr_m_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, "m_X");
			Vector2Int.NativeFieldInfoPtr_m_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, "m_Y");
			Vector2Int.NativeFieldInfoPtr_s_Zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, "s_Zero");
			Vector2Int.NativeFieldInfoPtr_s_One = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, "s_One");
			Vector2Int.NativeFieldInfoPtr_s_Up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, "s_Up");
			Vector2Int.NativeFieldInfoPtr_s_Down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, "s_Down");
			Vector2Int.NativeFieldInfoPtr_s_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, "s_Left");
			Vector2Int.NativeFieldInfoPtr_s_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, "s_Right");
			Vector2Int.NativeMethodInfoPtr_get_x_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100666295);
			Vector2Int.NativeMethodInfoPtr_set_x_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100666296);
			Vector2Int.NativeMethodInfoPtr_get_y_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100666297);
			Vector2Int.NativeMethodInfoPtr_set_y_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100666298);
			Vector2Int.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100666299);
			Vector2Int.NativeMethodInfoPtr_get_magnitude_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100666300);
			Vector2Int.NativeMethodInfoPtr_Max_Public_Static_Vector2Int_Vector2Int_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100666301);
			Vector2Int.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100666302);
			Vector2Int.NativeMethodInfoPtr_FloorToInt_Public_Static_Vector2Int_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100666303);
			Vector2Int.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Vector2Int_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100666304);
			Vector2Int.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Vector2Int_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100666305);
			Vector2Int.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100666306);
			Vector2Int.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100666307);
			Vector2Int.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100666308);
			Vector2Int.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100666309);
			Vector2Int.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100666310);
			Vector2Int.NativeMethodInfoPtr_get_zero_Public_Static_get_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100666311);
			Vector2Int.NativeMethodInfoPtr_get_one_Public_Static_get_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100666312);
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06001538 RID: 5432 RVA: 0x00068B2C File Offset: 0x00066D2C
		// (set) Token: 0x06001539 RID: 5433 RVA: 0x00068B5C File Offset: 0x00066D5C
		public unsafe int x
		{
			[CallerCount(236)]
			[CachedScanResults(RefRangeStart = 283634, RefRangeEnd = 283870, XrefRangeStart = 283634, XrefRangeEnd = 283870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_get_x_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_set_x_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x0600153A RID: 5434 RVA: 0x00068B90 File Offset: 0x00066D90
		// (set) Token: 0x0600153B RID: 5435 RVA: 0x00068BC0 File Offset: 0x00066DC0
		public unsafe int y
		{
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 283125, RefRangeEnd = 283150, XrefRangeStart = 283125, XrefRangeEnd = 283150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_get_y_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 320170, RefRangeEnd = 320176, XrefRangeStart = 320170, XrefRangeEnd = 320176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_set_y_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600153C RID: 5436 RVA: 0x00068BF4 File Offset: 0x00066DF4
		[CallerCount(39)]
		[CachedScanResults(RefRangeStart = 283577, RefRangeEnd = 283616, XrefRangeStart = 283577, XrefRangeEnd = 283616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2Int(int x, int y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x0600153D RID: 5437 RVA: 0x00068C34 File Offset: 0x00066E34
		public unsafe float magnitude
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_get_magnitude_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600153E RID: 5438 RVA: 0x00068C64 File Offset: 0x00066E64
		[CallerCount(0)]
		public unsafe static Vector2Int Max(Vector2Int lhs, Vector2Int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_Max_Public_Static_Vector2Int_Vector2Int_Vector2Int_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600153F RID: 5439 RVA: 0x00068CB0 File Offset: 0x00066EB0
		[CallerCount(0)]
		public unsafe static implicit operator Vector2(Vector2Int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_Vector2Int_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001540 RID: 5440 RVA: 0x00068CF0 File Offset: 0x00066EF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659755, XrefRangeEnd = 659763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2Int FloorToInt(Vector2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_FloorToInt_Public_Static_Vector2Int_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001541 RID: 5441 RVA: 0x00068D30 File Offset: 0x00066F30
		[CallerCount(0)]
		public unsafe static bool operator ==(Vector2Int lhs, Vector2Int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Vector2Int_Vector2Int_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001542 RID: 5442 RVA: 0x00068D7C File Offset: 0x00066F7C
		[CallerCount(0)]
		public unsafe static bool operator !=(Vector2Int lhs, Vector2Int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Vector2Int_Vector2Int_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001543 RID: 5443 RVA: 0x00068DC8 File Offset: 0x00066FC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659763, XrefRangeEnd = 659766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001544 RID: 5444 RVA: 0x00068E0C File Offset: 0x0006700C
		[CallerCount(0)]
		public unsafe bool Equals(Vector2Int other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Vector2Int_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001545 RID: 5445 RVA: 0x00068E4C File Offset: 0x0006704C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659766, XrefRangeEnd = 659768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001546 RID: 5446 RVA: 0x00068E7C File Offset: 0x0006707C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659768, XrefRangeEnd = 659776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001547 RID: 5447 RVA: 0x00068EA8 File Offset: 0x000670A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659776, XrefRangeEnd = 659792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format, IFormatProvider formatProvider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06001548 RID: 5448 RVA: 0x00068EF8 File Offset: 0x000670F8
		public unsafe static Vector2Int zero
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659792, XrefRangeEnd = 659794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_get_zero_Public_Static_get_Vector2Int_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06001549 RID: 5449 RVA: 0x00068F28 File Offset: 0x00067128
		public unsafe static Vector2Int one
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659794, XrefRangeEnd = 659796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_get_one_Public_Static_get_Vector2Int_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600154A RID: 5450 RVA: 0x00008620 File Offset: 0x00006820
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, ref this));
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x0600154B RID: 5451 RVA: 0x00068F58 File Offset: 0x00067158
		// (set) Token: 0x0600154C RID: 5452 RVA: 0x00008632 File Offset: 0x00006832
		public unsafe static Vector2Int s_Zero
		{
			get
			{
				Vector2Int vector2Int;
				IL2CPP.il2cpp_field_static_get_value(Vector2Int.NativeFieldInfoPtr_s_Zero, (void*)(&vector2Int));
				return vector2Int;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector2Int.NativeFieldInfoPtr_s_Zero, (void*)(&value));
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x0600154D RID: 5453 RVA: 0x00068F74 File Offset: 0x00067174
		// (set) Token: 0x0600154E RID: 5454 RVA: 0x00008640 File Offset: 0x00006840
		public unsafe static Vector2Int s_One
		{
			get
			{
				Vector2Int vector2Int;
				IL2CPP.il2cpp_field_static_get_value(Vector2Int.NativeFieldInfoPtr_s_One, (void*)(&vector2Int));
				return vector2Int;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector2Int.NativeFieldInfoPtr_s_One, (void*)(&value));
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x0600154F RID: 5455 RVA: 0x00068F90 File Offset: 0x00067190
		// (set) Token: 0x06001550 RID: 5456 RVA: 0x0000864E File Offset: 0x0000684E
		public unsafe static Vector2Int s_Up
		{
			get
			{
				Vector2Int vector2Int;
				IL2CPP.il2cpp_field_static_get_value(Vector2Int.NativeFieldInfoPtr_s_Up, (void*)(&vector2Int));
				return vector2Int;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector2Int.NativeFieldInfoPtr_s_Up, (void*)(&value));
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06001551 RID: 5457 RVA: 0x00068FAC File Offset: 0x000671AC
		// (set) Token: 0x06001552 RID: 5458 RVA: 0x0000865C File Offset: 0x0000685C
		public unsafe static Vector2Int s_Down
		{
			get
			{
				Vector2Int vector2Int;
				IL2CPP.il2cpp_field_static_get_value(Vector2Int.NativeFieldInfoPtr_s_Down, (void*)(&vector2Int));
				return vector2Int;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector2Int.NativeFieldInfoPtr_s_Down, (void*)(&value));
			}
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06001553 RID: 5459 RVA: 0x00068FC8 File Offset: 0x000671C8
		// (set) Token: 0x06001554 RID: 5460 RVA: 0x0000866A File Offset: 0x0000686A
		public unsafe static Vector2Int s_Left
		{
			get
			{
				Vector2Int vector2Int;
				IL2CPP.il2cpp_field_static_get_value(Vector2Int.NativeFieldInfoPtr_s_Left, (void*)(&vector2Int));
				return vector2Int;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector2Int.NativeFieldInfoPtr_s_Left, (void*)(&value));
			}
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06001555 RID: 5461 RVA: 0x00068FE4 File Offset: 0x000671E4
		// (set) Token: 0x06001556 RID: 5462 RVA: 0x00008678 File Offset: 0x00006878
		public unsafe static Vector2Int s_Right
		{
			get
			{
				Vector2Int vector2Int;
				IL2CPP.il2cpp_field_static_get_value(Vector2Int.NativeFieldInfoPtr_s_Right, (void*)(&vector2Int));
				return vector2Int;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector2Int.NativeFieldInfoPtr_s_Right, (void*)(&value));
			}
		}

		// Token: 0x06001557 RID: 5463 RVA: 0x00008686 File Offset: 0x00006886
		public void Set(int x, int y)
		{
			this.m_X = x;
			this.m_Y = y;
		}

		// Token: 0x17000467 RID: 1127
		public int this[int index]
		{
			get
			{
				int num;
				if (index != 0)
				{
					if (index != 1)
					{
						throw new IndexOutOfRangeException(String.Format("Invalid Vector2Int index addressed: {0}!", index));
					}
					num = this.y;
				}
				else
				{
					num = this.x;
				}
				return num;
			}
			set
			{
				if (index != 0)
				{
					if (index != 1)
					{
						throw new IndexOutOfRangeException(String.Format("Invalid Vector2Int index addressed: {0}!", index));
					}
					this.y = value;
				}
				else
				{
					this.x = value;
				}
			}
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x0600155A RID: 5466 RVA: 0x00069090 File Offset: 0x00067290
		public int sqrMagnitude
		{
			get
			{
				return this.x * this.x + this.y * this.y;
			}
		}

		// Token: 0x0600155B RID: 5467 RVA: 0x000690C0 File Offset: 0x000672C0
		public static float Distance(Vector2Int a, Vector2Int b)
		{
			float num = (float)(a.x - b.x);
			float num2 = (float)(a.y - b.y);
			return (float)Math.Sqrt((double)(num * num + num2 * num2));
		}

		// Token: 0x0600155C RID: 5468 RVA: 0x00069104 File Offset: 0x00067304
		public static Vector2Int Min(Vector2Int lhs, Vector2Int rhs)
		{
			return new Vector2Int(Mathf.Min(lhs.x, rhs.x), Mathf.Min(lhs.y, rhs.y));
		}

		// Token: 0x0600155D RID: 5469 RVA: 0x00069144 File Offset: 0x00067344
		public static Vector2Int Scale(Vector2Int a, Vector2Int b)
		{
			return new Vector2Int(a.x * b.x, a.y * b.y);
		}

		// Token: 0x0600155E RID: 5470 RVA: 0x00008697 File Offset: 0x00006897
		public void Scale(Vector2Int scale)
		{
			this.x *= scale.x;
			this.y *= scale.y;
		}

		// Token: 0x0600155F RID: 5471 RVA: 0x0006917C File Offset: 0x0006737C
		public void Clamp(Vector2Int min, Vector2Int max)
		{
			this.x = Math.Max(min.x, this.x);
			this.x = Math.Min(max.x, this.x);
			this.y = Math.Max(min.y, this.y);
			this.y = Math.Min(max.y, this.y);
		}

		// Token: 0x06001560 RID: 5472 RVA: 0x000691F0 File Offset: 0x000673F0
		public static explicit operator Vector3Int(Vector2Int v)
		{
			return new Vector3Int(v.x, v.y, 0);
		}

		// Token: 0x06001561 RID: 5473 RVA: 0x00069218 File Offset: 0x00067418
		public static Vector2Int CeilToInt(Vector2 v)
		{
			return new Vector2Int(Mathf.CeilToInt(v.x), Mathf.CeilToInt(v.y));
		}

		// Token: 0x06001562 RID: 5474 RVA: 0x00069248 File Offset: 0x00067448
		public static Vector2Int RoundToInt(Vector2 v)
		{
			return new Vector2Int(Mathf.RoundToInt(v.x), Mathf.RoundToInt(v.y));
		}

		// Token: 0x06001563 RID: 5475 RVA: 0x00069278 File Offset: 0x00067478
		public static Vector2Int operator -(Vector2Int v)
		{
			return new Vector2Int(-v.x, -v.y);
		}

		// Token: 0x06001564 RID: 5476 RVA: 0x000692A0 File Offset: 0x000674A0
		public static Vector2Int operator +(Vector2Int a, Vector2Int b)
		{
			return new Vector2Int(a.x + b.x, a.y + b.y);
		}

		// Token: 0x06001565 RID: 5477 RVA: 0x000692D8 File Offset: 0x000674D8
		public static Vector2Int operator -(Vector2Int a, Vector2Int b)
		{
			return new Vector2Int(a.x - b.x, a.y - b.y);
		}

		// Token: 0x06001566 RID: 5478 RVA: 0x00069310 File Offset: 0x00067510
		public static Vector2Int operator *(Vector2Int a, Vector2Int b)
		{
			return new Vector2Int(a.x * b.x, a.y * b.y);
		}

		// Token: 0x06001567 RID: 5479 RVA: 0x00069348 File Offset: 0x00067548
		public static Vector2Int operator *(int a, Vector2Int b)
		{
			return new Vector2Int(a * b.x, a * b.y);
		}

		// Token: 0x06001568 RID: 5480 RVA: 0x00069374 File Offset: 0x00067574
		public static Vector2Int operator *(Vector2Int a, int b)
		{
			return new Vector2Int(a.x * b, a.y * b);
		}

		// Token: 0x06001569 RID: 5481 RVA: 0x000693A0 File Offset: 0x000675A0
		public static Vector2Int operator /(Vector2Int a, int b)
		{
			return new Vector2Int(a.x / b, a.y / b);
		}

		// Token: 0x0600156A RID: 5482 RVA: 0x000693CC File Offset: 0x000675CC
		public string ToString(string format)
		{
			return this.ToString(format, null);
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x0600156B RID: 5483 RVA: 0x000693E8 File Offset: 0x000675E8
		public static Vector2Int up
		{
			get
			{
				return Vector2Int.s_Up;
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x0600156C RID: 5484 RVA: 0x00069400 File Offset: 0x00067600
		public static Vector2Int down
		{
			get
			{
				return Vector2Int.s_Down;
			}
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x0600156D RID: 5485 RVA: 0x00069418 File Offset: 0x00067618
		public static Vector2Int left
		{
			get
			{
				return Vector2Int.s_Left;
			}
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x0600156E RID: 5486 RVA: 0x00069430 File Offset: 0x00067630
		public static Vector2Int right
		{
			get
			{
				return Vector2Int.s_Right;
			}
		}

		// Token: 0x040013FA RID: 5114
		private static readonly IntPtr NativeFieldInfoPtr_m_X;

		// Token: 0x040013FB RID: 5115
		private static readonly IntPtr NativeFieldInfoPtr_m_Y;

		// Token: 0x040013FC RID: 5116
		private static readonly IntPtr NativeFieldInfoPtr_s_Zero;

		// Token: 0x040013FD RID: 5117
		private static readonly IntPtr NativeFieldInfoPtr_s_One;

		// Token: 0x040013FE RID: 5118
		private static readonly IntPtr NativeFieldInfoPtr_s_Up;

		// Token: 0x040013FF RID: 5119
		private static readonly IntPtr NativeFieldInfoPtr_s_Down;

		// Token: 0x04001400 RID: 5120
		private static readonly IntPtr NativeFieldInfoPtr_s_Left;

		// Token: 0x04001401 RID: 5121
		private static readonly IntPtr NativeFieldInfoPtr_s_Right;

		// Token: 0x04001402 RID: 5122
		private static readonly IntPtr NativeMethodInfoPtr_get_x_Public_get_Int32_0;

		// Token: 0x04001403 RID: 5123
		private static readonly IntPtr NativeMethodInfoPtr_set_x_Public_set_Void_Int32_0;

		// Token: 0x04001404 RID: 5124
		private static readonly IntPtr NativeMethodInfoPtr_get_y_Public_get_Int32_0;

		// Token: 0x04001405 RID: 5125
		private static readonly IntPtr NativeMethodInfoPtr_set_y_Public_set_Void_Int32_0;

		// Token: 0x04001406 RID: 5126
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		// Token: 0x04001407 RID: 5127
		private static readonly IntPtr NativeMethodInfoPtr_get_magnitude_Public_get_Single_0;

		// Token: 0x04001408 RID: 5128
		private static readonly IntPtr NativeMethodInfoPtr_Max_Public_Static_Vector2Int_Vector2Int_Vector2Int_0;

		// Token: 0x04001409 RID: 5129
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_Vector2Int_0;

		// Token: 0x0400140A RID: 5130
		private static readonly IntPtr NativeMethodInfoPtr_FloorToInt_Public_Static_Vector2Int_Vector2_0;

		// Token: 0x0400140B RID: 5131
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Vector2Int_Vector2Int_0;

		// Token: 0x0400140C RID: 5132
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Vector2Int_Vector2Int_0;

		// Token: 0x0400140D RID: 5133
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400140E RID: 5134
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Vector2Int_0;

		// Token: 0x0400140F RID: 5135
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001410 RID: 5136
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001411 RID: 5137
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04001412 RID: 5138
		private static readonly IntPtr NativeMethodInfoPtr_get_zero_Public_Static_get_Vector2Int_0;

		// Token: 0x04001413 RID: 5139
		private static readonly IntPtr NativeMethodInfoPtr_get_one_Public_Static_get_Vector2Int_0;

		// Token: 0x04001414 RID: 5140
		[FieldOffset(0)]
		public int m_X;

		// Token: 0x04001415 RID: 5141
		[FieldOffset(4)]
		public int m_Y;
	}
}
