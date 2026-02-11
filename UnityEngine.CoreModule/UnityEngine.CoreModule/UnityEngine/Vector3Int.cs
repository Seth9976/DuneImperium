using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000103 RID: 259
	[StructLayout(2)]
	public struct Vector3Int
	{
		// Token: 0x0600156F RID: 5487 RVA: 0x00069448 File Offset: 0x00067648
		// Note: this type is marked as 'beforefieldinit'.
		static Vector3Int()
		{
			Il2CppClassPointerStore<Vector3Int>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Vector3Int");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr);
			Vector3Int.NativeFieldInfoPtr_m_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, "m_X");
			Vector3Int.NativeFieldInfoPtr_m_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, "m_Y");
			Vector3Int.NativeFieldInfoPtr_m_Z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, "m_Z");
			Vector3Int.NativeFieldInfoPtr_s_Zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, "s_Zero");
			Vector3Int.NativeFieldInfoPtr_s_One = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, "s_One");
			Vector3Int.NativeFieldInfoPtr_s_Up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, "s_Up");
			Vector3Int.NativeFieldInfoPtr_s_Down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, "s_Down");
			Vector3Int.NativeFieldInfoPtr_s_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, "s_Left");
			Vector3Int.NativeFieldInfoPtr_s_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, "s_Right");
			Vector3Int.NativeFieldInfoPtr_s_Forward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, "s_Forward");
			Vector3Int.NativeFieldInfoPtr_s_Back = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, "s_Back");
			Vector3Int.NativeMethodInfoPtr_get_x_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100666314);
			Vector3Int.NativeMethodInfoPtr_set_x_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100666315);
			Vector3Int.NativeMethodInfoPtr_get_y_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100666316);
			Vector3Int.NativeMethodInfoPtr_set_y_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100666317);
			Vector3Int.NativeMethodInfoPtr_get_z_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100666318);
			Vector3Int.NativeMethodInfoPtr_set_z_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100666319);
			Vector3Int.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100666320);
			Vector3Int.NativeMethodInfoPtr_Min_Public_Static_Vector3Int_Vector3Int_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100666321);
			Vector3Int.NativeMethodInfoPtr_Max_Public_Static_Vector3Int_Vector3Int_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100666322);
			Vector3Int.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector3_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100666323);
			Vector3Int.NativeMethodInfoPtr_op_Addition_Public_Static_Vector3Int_Vector3Int_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100666324);
			Vector3Int.NativeMethodInfoPtr_op_Subtraction_Public_Static_Vector3Int_Vector3Int_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100666325);
			Vector3Int.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector3Int_Vector3Int_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100666326);
			Vector3Int.NativeMethodInfoPtr_op_Division_Public_Static_Vector3Int_Vector3Int_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100666327);
			Vector3Int.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Vector3Int_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100666328);
			Vector3Int.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Vector3Int_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100666329);
			Vector3Int.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100666330);
			Vector3Int.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100666331);
			Vector3Int.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100666332);
			Vector3Int.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100666333);
			Vector3Int.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100666334);
			Vector3Int.NativeMethodInfoPtr_get_zero_Public_Static_get_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100666335);
			Vector3Int.NativeMethodInfoPtr_get_one_Public_Static_get_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100666336);
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06001570 RID: 5488 RVA: 0x00069720 File Offset: 0x00067920
		// (set) Token: 0x06001571 RID: 5489 RVA: 0x00069750 File Offset: 0x00067950
		public unsafe int x
		{
			[CallerCount(236)]
			[CachedScanResults(RefRangeStart = 283634, RefRangeEnd = 283870, XrefRangeStart = 283634, XrefRangeEnd = 283870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_get_x_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_set_x_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06001572 RID: 5490 RVA: 0x00069784 File Offset: 0x00067984
		// (set) Token: 0x06001573 RID: 5491 RVA: 0x000697B4 File Offset: 0x000679B4
		public unsafe int y
		{
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 283125, RefRangeEnd = 283150, XrefRangeStart = 283125, XrefRangeEnd = 283150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_get_y_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_set_y_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06001574 RID: 5492 RVA: 0x000697E8 File Offset: 0x000679E8
		// (set) Token: 0x06001575 RID: 5493 RVA: 0x00069818 File Offset: 0x00067A18
		public unsafe int z
		{
			[CallerCount(27)]
			[CachedScanResults(RefRangeStart = 335516, RefRangeEnd = 335543, XrefRangeStart = 335516, XrefRangeEnd = 335543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_get_z_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 310301, RefRangeEnd = 310309, XrefRangeStart = 310301, XrefRangeEnd = 310309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_set_z_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001576 RID: 5494 RVA: 0x0006984C File Offset: 0x00067A4C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 556229, RefRangeEnd = 556238, XrefRangeStart = 556229, XrefRangeEnd = 556238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3Int(int x, int y, int z)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001577 RID: 5495 RVA: 0x0006989C File Offset: 0x00067A9C
		[CallerCount(0)]
		public unsafe static Vector3Int Min(Vector3Int lhs, Vector3Int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_Min_Public_Static_Vector3Int_Vector3Int_Vector3Int_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001578 RID: 5496 RVA: 0x000698E8 File Offset: 0x00067AE8
		[CallerCount(0)]
		public unsafe static Vector3Int Max(Vector3Int lhs, Vector3Int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_Max_Public_Static_Vector3Int_Vector3Int_Vector3Int_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001579 RID: 5497 RVA: 0x00069934 File Offset: 0x00067B34
		[CallerCount(0)]
		public unsafe static implicit operator Vector3(Vector3Int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector3_Vector3Int_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600157A RID: 5498 RVA: 0x00069974 File Offset: 0x00067B74
		[CallerCount(0)]
		public unsafe static Vector3Int operator +(Vector3Int a, Vector3Int b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_op_Addition_Public_Static_Vector3Int_Vector3Int_Vector3Int_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600157B RID: 5499 RVA: 0x000699C0 File Offset: 0x00067BC0
		[CallerCount(0)]
		public unsafe static Vector3Int operator -(Vector3Int a, Vector3Int b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_op_Subtraction_Public_Static_Vector3Int_Vector3Int_Vector3Int_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600157C RID: 5500 RVA: 0x00069A0C File Offset: 0x00067C0C
		[CallerCount(0)]
		public unsafe static Vector3Int operator *(Vector3Int a, int b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector3Int_Vector3Int_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600157D RID: 5501 RVA: 0x00069A58 File Offset: 0x00067C58
		[CallerCount(0)]
		public unsafe static Vector3Int operator /(Vector3Int a, int b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_op_Division_Public_Static_Vector3Int_Vector3Int_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600157E RID: 5502 RVA: 0x00069AA4 File Offset: 0x00067CA4
		[CallerCount(0)]
		public unsafe static bool operator ==(Vector3Int lhs, Vector3Int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Vector3Int_Vector3Int_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600157F RID: 5503 RVA: 0x00069AF0 File Offset: 0x00067CF0
		[CallerCount(0)]
		public unsafe static bool operator !=(Vector3Int lhs, Vector3Int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Vector3Int_Vector3Int_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001580 RID: 5504 RVA: 0x00069B3C File Offset: 0x00067D3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659796, XrefRangeEnd = 659799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001581 RID: 5505 RVA: 0x00069B80 File Offset: 0x00067D80
		[CallerCount(0)]
		public unsafe bool Equals(Vector3Int other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Vector3Int_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001582 RID: 5506 RVA: 0x00069BC0 File Offset: 0x00067DC0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 659802, RefRangeEnd = 659804, XrefRangeStart = 659799, XrefRangeEnd = 659802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001583 RID: 5507 RVA: 0x00069BF0 File Offset: 0x00067DF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659804, XrefRangeEnd = 659805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001584 RID: 5508 RVA: 0x00069C1C File Offset: 0x00067E1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659805, XrefRangeEnd = 659824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06001585 RID: 5509 RVA: 0x00069C6C File Offset: 0x00067E6C
		public unsafe static Vector3Int zero
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659824, XrefRangeEnd = 659826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_get_zero_Public_Static_get_Vector3Int_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06001586 RID: 5510 RVA: 0x00069C9C File Offset: 0x00067E9C
		public unsafe static Vector3Int one
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659826, XrefRangeEnd = 659828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_get_one_Public_Static_get_Vector3Int_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001587 RID: 5511 RVA: 0x000086C4 File Offset: 0x000068C4
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, ref this));
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06001588 RID: 5512 RVA: 0x00069CCC File Offset: 0x00067ECC
		// (set) Token: 0x06001589 RID: 5513 RVA: 0x000086D6 File Offset: 0x000068D6
		public unsafe static Vector3Int s_Zero
		{
			get
			{
				Vector3Int vector3Int;
				IL2CPP.il2cpp_field_static_get_value(Vector3Int.NativeFieldInfoPtr_s_Zero, (void*)(&vector3Int));
				return vector3Int;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector3Int.NativeFieldInfoPtr_s_Zero, (void*)(&value));
			}
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x0600158A RID: 5514 RVA: 0x00069CE8 File Offset: 0x00067EE8
		// (set) Token: 0x0600158B RID: 5515 RVA: 0x000086E4 File Offset: 0x000068E4
		public unsafe static Vector3Int s_One
		{
			get
			{
				Vector3Int vector3Int;
				IL2CPP.il2cpp_field_static_get_value(Vector3Int.NativeFieldInfoPtr_s_One, (void*)(&vector3Int));
				return vector3Int;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector3Int.NativeFieldInfoPtr_s_One, (void*)(&value));
			}
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x0600158C RID: 5516 RVA: 0x00069D04 File Offset: 0x00067F04
		// (set) Token: 0x0600158D RID: 5517 RVA: 0x000086F2 File Offset: 0x000068F2
		public unsafe static Vector3Int s_Up
		{
			get
			{
				Vector3Int vector3Int;
				IL2CPP.il2cpp_field_static_get_value(Vector3Int.NativeFieldInfoPtr_s_Up, (void*)(&vector3Int));
				return vector3Int;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector3Int.NativeFieldInfoPtr_s_Up, (void*)(&value));
			}
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x0600158E RID: 5518 RVA: 0x00069D20 File Offset: 0x00067F20
		// (set) Token: 0x0600158F RID: 5519 RVA: 0x00008700 File Offset: 0x00006900
		public unsafe static Vector3Int s_Down
		{
			get
			{
				Vector3Int vector3Int;
				IL2CPP.il2cpp_field_static_get_value(Vector3Int.NativeFieldInfoPtr_s_Down, (void*)(&vector3Int));
				return vector3Int;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector3Int.NativeFieldInfoPtr_s_Down, (void*)(&value));
			}
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06001590 RID: 5520 RVA: 0x00069D3C File Offset: 0x00067F3C
		// (set) Token: 0x06001591 RID: 5521 RVA: 0x0000870E File Offset: 0x0000690E
		public unsafe static Vector3Int s_Left
		{
			get
			{
				Vector3Int vector3Int;
				IL2CPP.il2cpp_field_static_get_value(Vector3Int.NativeFieldInfoPtr_s_Left, (void*)(&vector3Int));
				return vector3Int;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector3Int.NativeFieldInfoPtr_s_Left, (void*)(&value));
			}
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06001592 RID: 5522 RVA: 0x00069D58 File Offset: 0x00067F58
		// (set) Token: 0x06001593 RID: 5523 RVA: 0x0000871C File Offset: 0x0000691C
		public unsafe static Vector3Int s_Right
		{
			get
			{
				Vector3Int vector3Int;
				IL2CPP.il2cpp_field_static_get_value(Vector3Int.NativeFieldInfoPtr_s_Right, (void*)(&vector3Int));
				return vector3Int;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector3Int.NativeFieldInfoPtr_s_Right, (void*)(&value));
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06001594 RID: 5524 RVA: 0x00069D74 File Offset: 0x00067F74
		// (set) Token: 0x06001595 RID: 5525 RVA: 0x0000872A File Offset: 0x0000692A
		public unsafe static Vector3Int s_Forward
		{
			get
			{
				Vector3Int vector3Int;
				IL2CPP.il2cpp_field_static_get_value(Vector3Int.NativeFieldInfoPtr_s_Forward, (void*)(&vector3Int));
				return vector3Int;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector3Int.NativeFieldInfoPtr_s_Forward, (void*)(&value));
			}
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06001596 RID: 5526 RVA: 0x00069D90 File Offset: 0x00067F90
		// (set) Token: 0x06001597 RID: 5527 RVA: 0x00008738 File Offset: 0x00006938
		public unsafe static Vector3Int s_Back
		{
			get
			{
				Vector3Int vector3Int;
				IL2CPP.il2cpp_field_static_get_value(Vector3Int.NativeFieldInfoPtr_s_Back, (void*)(&vector3Int));
				return vector3Int;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector3Int.NativeFieldInfoPtr_s_Back, (void*)(&value));
			}
		}

		// Token: 0x06001598 RID: 5528 RVA: 0x00008746 File Offset: 0x00006946
		public void Set(int x, int y, int z)
		{
			this.m_X = x;
			this.m_Y = y;
			this.m_Z = z;
		}

		// Token: 0x1700047A RID: 1146
		public int this[int index]
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x0600159B RID: 5531 RVA: 0x00069DAC File Offset: 0x00067FAC
		public float magnitude
		{
			get
			{
				return Mathf.Sqrt((float)(this.x * this.x + this.y * this.y + this.z * this.z));
			}
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x0600159C RID: 5532 RVA: 0x00069DF0 File Offset: 0x00067FF0
		public int sqrMagnitude
		{
			get
			{
				return this.x * this.x + this.y * this.y + this.z * this.z;
			}
		}

		// Token: 0x0600159D RID: 5533 RVA: 0x00069E2C File Offset: 0x0006802C
		public static float Distance(Vector3Int a, Vector3Int b)
		{
			return (a - b).magnitude;
		}

		// Token: 0x0600159E RID: 5534 RVA: 0x00069E50 File Offset: 0x00068050
		public static Vector3Int Scale(Vector3Int a, Vector3Int b)
		{
			return new Vector3Int(a.x * b.x, a.y * b.y, a.z * b.z);
		}

		// Token: 0x0600159F RID: 5535 RVA: 0x00069E94 File Offset: 0x00068094
		public void Scale(Vector3Int scale)
		{
			this.x *= scale.x;
			this.y *= scale.y;
			this.z *= scale.z;
		}

		// Token: 0x060015A0 RID: 5536 RVA: 0x00069EE4 File Offset: 0x000680E4
		public void Clamp(Vector3Int min, Vector3Int max)
		{
			this.x = Math.Max(min.x, this.x);
			this.x = Math.Min(max.x, this.x);
			this.y = Math.Max(min.y, this.y);
			this.y = Math.Min(max.y, this.y);
			this.z = Math.Max(min.z, this.z);
			this.z = Math.Min(max.z, this.z);
		}

		// Token: 0x060015A1 RID: 5537 RVA: 0x00069F88 File Offset: 0x00068188
		public static explicit operator Vector2Int(Vector3Int v)
		{
			return new Vector2Int(v.x, v.y);
		}

		// Token: 0x060015A2 RID: 5538 RVA: 0x00069FB0 File Offset: 0x000681B0
		public static Vector3Int FloorToInt(Vector3 v)
		{
			return new Vector3Int(Mathf.FloorToInt(v.x), Mathf.FloorToInt(v.y), Mathf.FloorToInt(v.z));
		}

		// Token: 0x060015A3 RID: 5539 RVA: 0x00069FE8 File Offset: 0x000681E8
		public static Vector3Int CeilToInt(Vector3 v)
		{
			return new Vector3Int(Mathf.CeilToInt(v.x), Mathf.CeilToInt(v.y), Mathf.CeilToInt(v.z));
		}

		// Token: 0x060015A4 RID: 5540 RVA: 0x0006A020 File Offset: 0x00068220
		public static Vector3Int RoundToInt(Vector3 v)
		{
			return new Vector3Int(Mathf.RoundToInt(v.x), Mathf.RoundToInt(v.y), Mathf.RoundToInt(v.z));
		}

		// Token: 0x060015A5 RID: 5541 RVA: 0x0006A058 File Offset: 0x00068258
		public static Vector3Int operator *(Vector3Int a, Vector3Int b)
		{
			return new Vector3Int(a.x * b.x, a.y * b.y, a.z * b.z);
		}

		// Token: 0x060015A6 RID: 5542 RVA: 0x0006A09C File Offset: 0x0006829C
		public static Vector3Int operator -(Vector3Int a)
		{
			return new Vector3Int(-a.x, -a.y, -a.z);
		}

		// Token: 0x060015A7 RID: 5543 RVA: 0x0006A0CC File Offset: 0x000682CC
		public static Vector3Int operator *(int a, Vector3Int b)
		{
			return new Vector3Int(a * b.x, a * b.y, a * b.z);
		}

		// Token: 0x060015A8 RID: 5544 RVA: 0x0006A100 File Offset: 0x00068300
		public string ToString(string format)
		{
			return this.ToString(format, null);
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x060015A9 RID: 5545 RVA: 0x0006A11C File Offset: 0x0006831C
		public static Vector3Int up
		{
			get
			{
				return Vector3Int.s_Up;
			}
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x060015AA RID: 5546 RVA: 0x0006A134 File Offset: 0x00068334
		public static Vector3Int down
		{
			get
			{
				return Vector3Int.s_Down;
			}
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x060015AB RID: 5547 RVA: 0x0006A14C File Offset: 0x0006834C
		public static Vector3Int left
		{
			get
			{
				return Vector3Int.s_Left;
			}
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x060015AC RID: 5548 RVA: 0x0006A164 File Offset: 0x00068364
		public static Vector3Int right
		{
			get
			{
				return Vector3Int.s_Right;
			}
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x060015AD RID: 5549 RVA: 0x0006A17C File Offset: 0x0006837C
		public static Vector3Int forward
		{
			get
			{
				return Vector3Int.s_Forward;
			}
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x060015AE RID: 5550 RVA: 0x0006A194 File Offset: 0x00068394
		public static Vector3Int back
		{
			get
			{
				return Vector3Int.s_Back;
			}
		}

		// Token: 0x04001416 RID: 5142
		private static readonly IntPtr NativeFieldInfoPtr_m_X;

		// Token: 0x04001417 RID: 5143
		private static readonly IntPtr NativeFieldInfoPtr_m_Y;

		// Token: 0x04001418 RID: 5144
		private static readonly IntPtr NativeFieldInfoPtr_m_Z;

		// Token: 0x04001419 RID: 5145
		private static readonly IntPtr NativeFieldInfoPtr_s_Zero;

		// Token: 0x0400141A RID: 5146
		private static readonly IntPtr NativeFieldInfoPtr_s_One;

		// Token: 0x0400141B RID: 5147
		private static readonly IntPtr NativeFieldInfoPtr_s_Up;

		// Token: 0x0400141C RID: 5148
		private static readonly IntPtr NativeFieldInfoPtr_s_Down;

		// Token: 0x0400141D RID: 5149
		private static readonly IntPtr NativeFieldInfoPtr_s_Left;

		// Token: 0x0400141E RID: 5150
		private static readonly IntPtr NativeFieldInfoPtr_s_Right;

		// Token: 0x0400141F RID: 5151
		private static readonly IntPtr NativeFieldInfoPtr_s_Forward;

		// Token: 0x04001420 RID: 5152
		private static readonly IntPtr NativeFieldInfoPtr_s_Back;

		// Token: 0x04001421 RID: 5153
		private static readonly IntPtr NativeMethodInfoPtr_get_x_Public_get_Int32_0;

		// Token: 0x04001422 RID: 5154
		private static readonly IntPtr NativeMethodInfoPtr_set_x_Public_set_Void_Int32_0;

		// Token: 0x04001423 RID: 5155
		private static readonly IntPtr NativeMethodInfoPtr_get_y_Public_get_Int32_0;

		// Token: 0x04001424 RID: 5156
		private static readonly IntPtr NativeMethodInfoPtr_set_y_Public_set_Void_Int32_0;

		// Token: 0x04001425 RID: 5157
		private static readonly IntPtr NativeMethodInfoPtr_get_z_Public_get_Int32_0;

		// Token: 0x04001426 RID: 5158
		private static readonly IntPtr NativeMethodInfoPtr_set_z_Public_set_Void_Int32_0;

		// Token: 0x04001427 RID: 5159
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0;

		// Token: 0x04001428 RID: 5160
		private static readonly IntPtr NativeMethodInfoPtr_Min_Public_Static_Vector3Int_Vector3Int_Vector3Int_0;

		// Token: 0x04001429 RID: 5161
		private static readonly IntPtr NativeMethodInfoPtr_Max_Public_Static_Vector3Int_Vector3Int_Vector3Int_0;

		// Token: 0x0400142A RID: 5162
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Vector3_Vector3Int_0;

		// Token: 0x0400142B RID: 5163
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_Vector3Int_Vector3Int_Vector3Int_0;

		// Token: 0x0400142C RID: 5164
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_Vector3Int_Vector3Int_Vector3Int_0;

		// Token: 0x0400142D RID: 5165
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Vector3Int_Vector3Int_Int32_0;

		// Token: 0x0400142E RID: 5166
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_Vector3Int_Vector3Int_Int32_0;

		// Token: 0x0400142F RID: 5167
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Vector3Int_Vector3Int_0;

		// Token: 0x04001430 RID: 5168
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Vector3Int_Vector3Int_0;

		// Token: 0x04001431 RID: 5169
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001432 RID: 5170
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Vector3Int_0;

		// Token: 0x04001433 RID: 5171
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001434 RID: 5172
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001435 RID: 5173
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04001436 RID: 5174
		private static readonly IntPtr NativeMethodInfoPtr_get_zero_Public_Static_get_Vector3Int_0;

		// Token: 0x04001437 RID: 5175
		private static readonly IntPtr NativeMethodInfoPtr_get_one_Public_Static_get_Vector3Int_0;

		// Token: 0x04001438 RID: 5176
		[FieldOffset(0)]
		public int m_X;

		// Token: 0x04001439 RID: 5177
		[FieldOffset(4)]
		public int m_Y;

		// Token: 0x0400143A RID: 5178
		[FieldOffset(8)]
		public int m_Z;
	}
}
