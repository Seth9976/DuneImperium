using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Jobs
{
	// Token: 0x02000191 RID: 401
	[StructLayout(2)]
	public struct TransformAccess
	{
		// Token: 0x06001DF4 RID: 7668 RVA: 0x00088158 File Offset: 0x00086358
		// Note: this type is marked as 'beforefieldinit'.
		static TransformAccess()
		{
			Il2CppClassPointerStore<TransformAccess>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Jobs", "TransformAccess");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransformAccess>.NativeClassPtr);
			TransformAccess.NativeFieldInfoPtr_hierarchy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformAccess>.NativeClassPtr, "hierarchy");
			TransformAccess.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformAccess>.NativeClassPtr, "index");
			TransformAccess.NativeMethodInfoPtr_get_position_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccess>.NativeClassPtr, 100667447);
			TransformAccess.NativeMethodInfoPtr_get_rotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccess>.NativeClassPtr, 100667448);
			TransformAccess.NativeMethodInfoPtr_get_localScale_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccess>.NativeClassPtr, 100667449);
			TransformAccess.NativeMethodInfoPtr_get_localToWorldMatrix_Public_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccess>.NativeClassPtr, 100667450);
			TransformAccess.NativeMethodInfoPtr_GetPosition_Private_Static_Void_byref_TransformAccess_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccess>.NativeClassPtr, 100667451);
			TransformAccess.NativeMethodInfoPtr_GetRotation_Private_Static_Void_byref_TransformAccess_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccess>.NativeClassPtr, 100667452);
			TransformAccess.NativeMethodInfoPtr_GetLocalScale_Private_Static_Void_byref_TransformAccess_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccess>.NativeClassPtr, 100667453);
			TransformAccess.NativeMethodInfoPtr_GetLocalToWorldMatrix_Private_Static_Void_byref_TransformAccess_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccess>.NativeClassPtr, 100667454);
			TransformAccess.SetPositionAndRotation_InternalDelegateField = IL2CPP.ResolveICall<TransformAccess.SetPositionAndRotation_InternalDelegate>("UnityEngine.Jobs.TransformAccess::SetPositionAndRotation_Internal");
			TransformAccess.SetLocalPositionAndRotation_InternalDelegateField = IL2CPP.ResolveICall<TransformAccess.SetLocalPositionAndRotation_InternalDelegate>("UnityEngine.Jobs.TransformAccess::SetLocalPositionAndRotation_Internal");
			TransformAccess.GetPositionAndRotation_InternalDelegateField = IL2CPP.ResolveICall<TransformAccess.GetPositionAndRotation_InternalDelegate>("UnityEngine.Jobs.TransformAccess::GetPositionAndRotation_Internal");
			TransformAccess.GetLocalPositionAndRotation_InternalDelegateField = IL2CPP.ResolveICall<TransformAccess.GetLocalPositionAndRotation_InternalDelegate>("UnityEngine.Jobs.TransformAccess::GetLocalPositionAndRotation_Internal");
			TransformAccess.SetPositionDelegateField = IL2CPP.ResolveICall<TransformAccess.SetPositionDelegate>("UnityEngine.Jobs.TransformAccess::SetPosition");
			TransformAccess.SetRotationDelegateField = IL2CPP.ResolveICall<TransformAccess.SetRotationDelegate>("UnityEngine.Jobs.TransformAccess::SetRotation");
			TransformAccess.GetLocalPositionDelegateField = IL2CPP.ResolveICall<TransformAccess.GetLocalPositionDelegate>("UnityEngine.Jobs.TransformAccess::GetLocalPosition");
			TransformAccess.SetLocalPositionDelegateField = IL2CPP.ResolveICall<TransformAccess.SetLocalPositionDelegate>("UnityEngine.Jobs.TransformAccess::SetLocalPosition");
			TransformAccess.GetLocalRotationDelegateField = IL2CPP.ResolveICall<TransformAccess.GetLocalRotationDelegate>("UnityEngine.Jobs.TransformAccess::GetLocalRotation");
			TransformAccess.SetLocalRotationDelegateField = IL2CPP.ResolveICall<TransformAccess.SetLocalRotationDelegate>("UnityEngine.Jobs.TransformAccess::SetLocalRotation");
			TransformAccess.SetLocalScaleDelegateField = IL2CPP.ResolveICall<TransformAccess.SetLocalScaleDelegate>("UnityEngine.Jobs.TransformAccess::SetLocalScale");
			TransformAccess.GetWorldToLocalMatrixDelegateField = IL2CPP.ResolveICall<TransformAccess.GetWorldToLocalMatrixDelegate>("UnityEngine.Jobs.TransformAccess::GetWorldToLocalMatrix");
		}

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x06001DF5 RID: 7669 RVA: 0x00088304 File Offset: 0x00086504
		// (set) Token: 0x06001DFE RID: 7678 RVA: 0x0000B3BB File Offset: 0x000095BB
		public unsafe Vector3 position
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 677716, RefRangeEnd = 677718, XrefRangeStart = 677714, XrefRangeEnd = 677716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformAccess.NativeMethodInfoPtr_get_position_Public_get_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				TransformAccess.SetPosition(ref this, ref value);
			}
		}

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x06001DF6 RID: 7670 RVA: 0x00088334 File Offset: 0x00086534
		// (set) Token: 0x06001DFF RID: 7679 RVA: 0x0000B3C7 File Offset: 0x000095C7
		public unsafe Quaternion rotation
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 677720, RefRangeEnd = 677723, XrefRangeStart = 677718, XrefRangeEnd = 677720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformAccess.NativeMethodInfoPtr_get_rotation_Public_get_Quaternion_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				TransformAccess.SetRotation(ref this, ref value);
			}
		}

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x06001DF7 RID: 7671 RVA: 0x00088364 File Offset: 0x00086564
		// (set) Token: 0x06001E04 RID: 7684 RVA: 0x0000B3EB File Offset: 0x000095EB
		public unsafe Vector3 localScale
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 677725, RefRangeEnd = 677727, XrefRangeStart = 677723, XrefRangeEnd = 677725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformAccess.NativeMethodInfoPtr_get_localScale_Public_get_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				TransformAccess.SetLocalScale(ref this, ref value);
			}
		}

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x06001DF8 RID: 7672 RVA: 0x00088394 File Offset: 0x00086594
		public unsafe Matrix4x4 localToWorldMatrix
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 677729, RefRangeEnd = 677730, XrefRangeStart = 677727, XrefRangeEnd = 677729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformAccess.NativeMethodInfoPtr_get_localToWorldMatrix_Public_get_Matrix4x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001DF9 RID: 7673 RVA: 0x000883C4 File Offset: 0x000865C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677730, XrefRangeEnd = 677732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetPosition(ref TransformAccess access, out Vector3 p)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &access;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &p;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformAccess.NativeMethodInfoPtr_GetPosition_Private_Static_Void_byref_TransformAccess_byref_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DFA RID: 7674 RVA: 0x00088404 File Offset: 0x00086604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677732, XrefRangeEnd = 677734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetRotation(ref TransformAccess access, out Quaternion r)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &access;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &r;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformAccess.NativeMethodInfoPtr_GetRotation_Private_Static_Void_byref_TransformAccess_byref_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DFB RID: 7675 RVA: 0x00088444 File Offset: 0x00086644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677734, XrefRangeEnd = 677736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetLocalScale(ref TransformAccess access, out Vector3 r)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &access;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &r;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformAccess.NativeMethodInfoPtr_GetLocalScale_Private_Static_Void_byref_TransformAccess_byref_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DFC RID: 7676 RVA: 0x00088484 File Offset: 0x00086684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677736, XrefRangeEnd = 677738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetLocalToWorldMatrix(ref TransformAccess access, out Matrix4x4 m)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &access;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &m;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformAccess.NativeMethodInfoPtr_GetLocalToWorldMatrix_Private_Static_Void_byref_TransformAccess_byref_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DFD RID: 7677 RVA: 0x0000B3A9 File Offset: 0x000095A9
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TransformAccess>.NativeClassPtr, ref this));
		}

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x06001E00 RID: 7680 RVA: 0x000884C4 File Offset: 0x000866C4
		// (set) Token: 0x06001E01 RID: 7681 RVA: 0x0000B3D3 File Offset: 0x000095D3
		public Vector3 localPosition
		{
			get
			{
				Vector3 vector;
				TransformAccess.GetLocalPosition(ref this, out vector);
				return vector;
			}
			set
			{
				TransformAccess.SetLocalPosition(ref this, ref value);
			}
		}

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x06001E02 RID: 7682 RVA: 0x000884E0 File Offset: 0x000866E0
		// (set) Token: 0x06001E03 RID: 7683 RVA: 0x0000B3DF File Offset: 0x000095DF
		public Quaternion localRotation
		{
			get
			{
				Quaternion quaternion;
				TransformAccess.GetLocalRotation(ref this, out quaternion);
				return quaternion;
			}
			set
			{
				TransformAccess.SetLocalRotation(ref this, ref value);
			}
		}

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x06001E05 RID: 7685 RVA: 0x000884FC File Offset: 0x000866FC
		public Matrix4x4 worldToLocalMatrix
		{
			get
			{
				Matrix4x4 matrix4x;
				TransformAccess.GetWorldToLocalMatrix(ref this, out matrix4x);
				return matrix4x;
			}
		}

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x06001E06 RID: 7686 RVA: 0x0000B3F7 File Offset: 0x000095F7
		public bool isValid
		{
			get
			{
				return this.hierarchy != IntPtr.Zero;
			}
		}

		// Token: 0x06001E07 RID: 7687 RVA: 0x0000B409 File Offset: 0x00009609
		public void SetPositionAndRotation(Vector3 position, Quaternion rotation)
		{
			TransformAccess.SetPositionAndRotation_Internal(ref this, ref position, ref rotation);
		}

		// Token: 0x06001E08 RID: 7688 RVA: 0x0000B417 File Offset: 0x00009617
		public void SetLocalPositionAndRotation(Vector3 localPosition, Quaternion localRotation)
		{
			TransformAccess.SetLocalPositionAndRotation_Internal(ref this, ref localPosition, ref localRotation);
		}

		// Token: 0x06001E09 RID: 7689 RVA: 0x0000B425 File Offset: 0x00009625
		public void GetPositionAndRotation(out Vector3 position, out Quaternion rotation)
		{
			TransformAccess.GetPositionAndRotation_Internal(ref this, out position, out rotation);
		}

		// Token: 0x06001E0A RID: 7690 RVA: 0x0000B431 File Offset: 0x00009631
		public void GetLocalPositionAndRotation(out Vector3 localPosition, out Quaternion localRotation)
		{
			TransformAccess.GetLocalPositionAndRotation_Internal(ref this, out localPosition, out localRotation);
		}

		// Token: 0x06001E0B RID: 7691 RVA: 0x0000B43D File Offset: 0x0000963D
		public static void SetPositionAndRotation_Internal(ref TransformAccess access, ref Vector3 position, ref Quaternion rotation)
		{
			TransformAccess.SetPositionAndRotation_InternalDelegateField(ref access, ref position, ref rotation);
		}

		// Token: 0x06001E0C RID: 7692 RVA: 0x0000B44C File Offset: 0x0000964C
		public static void SetLocalPositionAndRotation_Internal(ref TransformAccess access, ref Vector3 localPosition, ref Quaternion localRotation)
		{
			TransformAccess.SetLocalPositionAndRotation_InternalDelegateField(ref access, ref localPosition, ref localRotation);
		}

		// Token: 0x06001E0D RID: 7693 RVA: 0x0000B45B File Offset: 0x0000965B
		public static void GetPositionAndRotation_Internal(ref TransformAccess access, out Vector3 position, out Quaternion rotation)
		{
			TransformAccess.GetPositionAndRotation_InternalDelegateField(ref access, out position, out rotation);
		}

		// Token: 0x06001E0E RID: 7694 RVA: 0x0000B46A File Offset: 0x0000966A
		public static void GetLocalPositionAndRotation_Internal(ref TransformAccess access, out Vector3 localPosition, out Quaternion localRotation)
		{
			TransformAccess.GetLocalPositionAndRotation_InternalDelegateField(ref access, out localPosition, out localRotation);
		}

		// Token: 0x06001E0F RID: 7695 RVA: 0x0000B479 File Offset: 0x00009679
		public static void SetPosition(ref TransformAccess access, ref Vector3 p)
		{
			TransformAccess.SetPositionDelegateField(ref access, ref p);
		}

		// Token: 0x06001E10 RID: 7696 RVA: 0x0000B487 File Offset: 0x00009687
		public static void SetRotation(ref TransformAccess access, ref Quaternion r)
		{
			TransformAccess.SetRotationDelegateField(ref access, ref r);
		}

		// Token: 0x06001E11 RID: 7697 RVA: 0x0000B495 File Offset: 0x00009695
		public static void GetLocalPosition(ref TransformAccess access, out Vector3 p)
		{
			TransformAccess.GetLocalPositionDelegateField(ref access, out p);
		}

		// Token: 0x06001E12 RID: 7698 RVA: 0x0000B4A3 File Offset: 0x000096A3
		public static void SetLocalPosition(ref TransformAccess access, ref Vector3 p)
		{
			TransformAccess.SetLocalPositionDelegateField(ref access, ref p);
		}

		// Token: 0x06001E13 RID: 7699 RVA: 0x0000B4B1 File Offset: 0x000096B1
		public static void GetLocalRotation(ref TransformAccess access, out Quaternion r)
		{
			TransformAccess.GetLocalRotationDelegateField(ref access, out r);
		}

		// Token: 0x06001E14 RID: 7700 RVA: 0x0000B4BF File Offset: 0x000096BF
		public static void SetLocalRotation(ref TransformAccess access, ref Quaternion r)
		{
			TransformAccess.SetLocalRotationDelegateField(ref access, ref r);
		}

		// Token: 0x06001E15 RID: 7701 RVA: 0x0000B4CD File Offset: 0x000096CD
		public static void SetLocalScale(ref TransformAccess access, ref Vector3 r)
		{
			TransformAccess.SetLocalScaleDelegateField(ref access, ref r);
		}

		// Token: 0x06001E16 RID: 7702 RVA: 0x0000B4DB File Offset: 0x000096DB
		public static void GetWorldToLocalMatrix(ref TransformAccess access, out Matrix4x4 m)
		{
			TransformAccess.GetWorldToLocalMatrixDelegateField(ref access, out m);
		}

		// Token: 0x06001E17 RID: 7703 RVA: 0x00088518 File Offset: 0x00086718
		public void CheckHierarchyValid()
		{
			bool flag = !this.isValid;
			if (flag)
			{
				throw new NullReferenceException("The TransformAccess is not valid and points to an invalid hierarchy");
			}
		}

		// Token: 0x06001E18 RID: 7704 RVA: 0x0000B4E9 File Offset: 0x000096E9
		public void MarkReadWrite()
		{
		}

		// Token: 0x06001E19 RID: 7705 RVA: 0x0000B4EC File Offset: 0x000096EC
		public void MarkReadOnly()
		{
		}

		// Token: 0x06001E1A RID: 7706 RVA: 0x0000B4EF File Offset: 0x000096EF
		public void CheckWriteAccess()
		{
		}

		// Token: 0x04001A56 RID: 6742
		private static readonly IntPtr NativeFieldInfoPtr_hierarchy;

		// Token: 0x04001A57 RID: 6743
		private static readonly IntPtr NativeFieldInfoPtr_index;

		// Token: 0x04001A58 RID: 6744
		private static readonly IntPtr NativeMethodInfoPtr_get_position_Public_get_Vector3_0;

		// Token: 0x04001A59 RID: 6745
		private static readonly IntPtr NativeMethodInfoPtr_get_rotation_Public_get_Quaternion_0;

		// Token: 0x04001A5A RID: 6746
		private static readonly IntPtr NativeMethodInfoPtr_get_localScale_Public_get_Vector3_0;

		// Token: 0x04001A5B RID: 6747
		private static readonly IntPtr NativeMethodInfoPtr_get_localToWorldMatrix_Public_get_Matrix4x4_0;

		// Token: 0x04001A5C RID: 6748
		private static readonly IntPtr NativeMethodInfoPtr_GetPosition_Private_Static_Void_byref_TransformAccess_byref_Vector3_0;

		// Token: 0x04001A5D RID: 6749
		private static readonly IntPtr NativeMethodInfoPtr_GetRotation_Private_Static_Void_byref_TransformAccess_byref_Quaternion_0;

		// Token: 0x04001A5E RID: 6750
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalScale_Private_Static_Void_byref_TransformAccess_byref_Vector3_0;

		// Token: 0x04001A5F RID: 6751
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalToWorldMatrix_Private_Static_Void_byref_TransformAccess_byref_Matrix4x4_0;

		// Token: 0x04001A60 RID: 6752
		[FieldOffset(0)]
		public IntPtr hierarchy;

		// Token: 0x04001A61 RID: 6753
		[FieldOffset(8)]
		public int index;

		// Token: 0x04001A62 RID: 6754
		private static readonly TransformAccess.SetPositionAndRotation_InternalDelegate SetPositionAndRotation_InternalDelegateField;

		// Token: 0x04001A63 RID: 6755
		private static readonly TransformAccess.SetLocalPositionAndRotation_InternalDelegate SetLocalPositionAndRotation_InternalDelegateField;

		// Token: 0x04001A64 RID: 6756
		private static readonly TransformAccess.GetPositionAndRotation_InternalDelegate GetPositionAndRotation_InternalDelegateField;

		// Token: 0x04001A65 RID: 6757
		private static readonly TransformAccess.GetLocalPositionAndRotation_InternalDelegate GetLocalPositionAndRotation_InternalDelegateField;

		// Token: 0x04001A66 RID: 6758
		private static readonly TransformAccess.SetPositionDelegate SetPositionDelegateField;

		// Token: 0x04001A67 RID: 6759
		private static readonly TransformAccess.SetRotationDelegate SetRotationDelegateField;

		// Token: 0x04001A68 RID: 6760
		private static readonly TransformAccess.GetLocalPositionDelegate GetLocalPositionDelegateField;

		// Token: 0x04001A69 RID: 6761
		private static readonly TransformAccess.SetLocalPositionDelegate SetLocalPositionDelegateField;

		// Token: 0x04001A6A RID: 6762
		private static readonly TransformAccess.GetLocalRotationDelegate GetLocalRotationDelegateField;

		// Token: 0x04001A6B RID: 6763
		private static readonly TransformAccess.SetLocalRotationDelegate SetLocalRotationDelegateField;

		// Token: 0x04001A6C RID: 6764
		private static readonly TransformAccess.SetLocalScaleDelegate SetLocalScaleDelegateField;

		// Token: 0x04001A6D RID: 6765
		private static readonly TransformAccess.GetWorldToLocalMatrixDelegate GetWorldToLocalMatrixDelegateField;

		// Token: 0x0200082E RID: 2094
		// (Invoke) Token: 0x0600390F RID: 14607
		private delegate void SetPositionAndRotation_InternalDelegate(IntPtr access, IntPtr position, IntPtr rotation);

		// Token: 0x0200082F RID: 2095
		// (Invoke) Token: 0x06003911 RID: 14609
		private delegate void SetLocalPositionAndRotation_InternalDelegate(IntPtr access, IntPtr localPosition, IntPtr localRotation);

		// Token: 0x02000830 RID: 2096
		// (Invoke) Token: 0x06003913 RID: 14611
		private delegate void GetPositionAndRotation_InternalDelegate(IntPtr access, [Out] IntPtr position, [Out] IntPtr rotation);

		// Token: 0x02000831 RID: 2097
		// (Invoke) Token: 0x06003915 RID: 14613
		private delegate void GetLocalPositionAndRotation_InternalDelegate(IntPtr access, [Out] IntPtr localPosition, [Out] IntPtr localRotation);

		// Token: 0x02000832 RID: 2098
		// (Invoke) Token: 0x06003917 RID: 14615
		private delegate void SetPositionDelegate(IntPtr access, IntPtr p);

		// Token: 0x02000833 RID: 2099
		// (Invoke) Token: 0x06003919 RID: 14617
		private delegate void SetRotationDelegate(IntPtr access, IntPtr r);

		// Token: 0x02000834 RID: 2100
		// (Invoke) Token: 0x0600391B RID: 14619
		private delegate void GetLocalPositionDelegate(IntPtr access, [Out] IntPtr p);

		// Token: 0x02000835 RID: 2101
		// (Invoke) Token: 0x0600391D RID: 14621
		private delegate void SetLocalPositionDelegate(IntPtr access, IntPtr p);

		// Token: 0x02000836 RID: 2102
		// (Invoke) Token: 0x0600391F RID: 14623
		private delegate void GetLocalRotationDelegate(IntPtr access, [Out] IntPtr r);

		// Token: 0x02000837 RID: 2103
		// (Invoke) Token: 0x06003921 RID: 14625
		private delegate void SetLocalRotationDelegate(IntPtr access, IntPtr r);

		// Token: 0x02000838 RID: 2104
		// (Invoke) Token: 0x06003923 RID: 14627
		private delegate void SetLocalScaleDelegate(IntPtr access, IntPtr r);

		// Token: 0x02000839 RID: 2105
		// (Invoke) Token: 0x06003925 RID: 14629
		private delegate void GetWorldToLocalMatrixDelegate(IntPtr access, [Out] IntPtr m);
	}
}
