using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200018D RID: 397
	[StructLayout(2)]
	public struct TransformData
	{
		// Token: 0x060020F7 RID: 8439 RVA: 0x00095458 File Offset: 0x00093658
		// Note: this type is marked as 'beforefieldinit'.
		static TransformData()
		{
			Il2CppClassPointerStore<TransformData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "TransformData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransformData>.NativeClassPtr);
			TransformData.NativeFieldInfoPtr_rotate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformData>.NativeClassPtr, "rotate");
			TransformData.NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformData>.NativeClassPtr, "scale");
			TransformData.NativeFieldInfoPtr_transformOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformData>.NativeClassPtr, "transformOrigin");
			TransformData.NativeFieldInfoPtr_translate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformData>.NativeClassPtr, "translate");
			TransformData.NativeMethodInfoPtr_Copy_Public_Virtual_Final_New_TransformData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformData>.NativeClassPtr, 100668174);
			TransformData.NativeMethodInfoPtr_CopyFrom_Public_Virtual_Final_New_Void_byref_TransformData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformData>.NativeClassPtr, 100668175);
			TransformData.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_TransformData_TransformData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformData>.NativeClassPtr, 100668176);
			TransformData.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TransformData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformData>.NativeClassPtr, 100668177);
			TransformData.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformData>.NativeClassPtr, 100668178);
			TransformData.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformData>.NativeClassPtr, 100668179);
		}

		// Token: 0x060020F8 RID: 8440 RVA: 0x00095550 File Offset: 0x00093750
		[CallerCount(0)]
		public unsafe TransformData Copy()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformData.NativeMethodInfoPtr_Copy_Public_Virtual_Final_New_TransformData_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020F9 RID: 8441 RVA: 0x00095580 File Offset: 0x00093780
		[CallerCount(0)]
		public unsafe void CopyFrom(ref TransformData other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformData.NativeMethodInfoPtr_CopyFrom_Public_Virtual_Final_New_Void_byref_TransformData_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060020FA RID: 8442 RVA: 0x000955B4 File Offset: 0x000937B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 334107, RefRangeEnd = 334109, XrefRangeStart = 334105, XrefRangeEnd = 334107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(TransformData lhs, TransformData rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformData.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_TransformData_TransformData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020FB RID: 8443 RVA: 0x00095600 File Offset: 0x00093800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334109, XrefRangeEnd = 334110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(TransformData other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformData.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TransformData_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060020FC RID: 8444 RVA: 0x00095640 File Offset: 0x00093840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334110, XrefRangeEnd = 334114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformData.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060020FD RID: 8445 RVA: 0x00095684 File Offset: 0x00093884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334114, XrefRangeEnd = 334124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformData.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020FE RID: 8446 RVA: 0x0000DD9C File Offset: 0x0000BF9C
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TransformData>.NativeClassPtr, ref this));
		}

		// Token: 0x060020FF RID: 8447 RVA: 0x000956B4 File Offset: 0x000938B4
		public static bool operator !=(TransformData lhs, TransformData rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x04001718 RID: 5912
		private static readonly IntPtr NativeFieldInfoPtr_rotate;

		// Token: 0x04001719 RID: 5913
		private static readonly IntPtr NativeFieldInfoPtr_scale;

		// Token: 0x0400171A RID: 5914
		private static readonly IntPtr NativeFieldInfoPtr_transformOrigin;

		// Token: 0x0400171B RID: 5915
		private static readonly IntPtr NativeFieldInfoPtr_translate;

		// Token: 0x0400171C RID: 5916
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Virtual_Final_New_TransformData_0;

		// Token: 0x0400171D RID: 5917
		private static readonly IntPtr NativeMethodInfoPtr_CopyFrom_Public_Virtual_Final_New_Void_byref_TransformData_0;

		// Token: 0x0400171E RID: 5918
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_TransformData_TransformData_0;

		// Token: 0x0400171F RID: 5919
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TransformData_0;

		// Token: 0x04001720 RID: 5920
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001721 RID: 5921
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001722 RID: 5922
		[FieldOffset(0)]
		public Rotate rotate;

		// Token: 0x04001723 RID: 5923
		[FieldOffset(24)]
		public Scale scale;

		// Token: 0x04001724 RID: 5924
		[FieldOffset(40)]
		public TransformOrigin transformOrigin;

		// Token: 0x04001725 RID: 5925
		[FieldOffset(60)]
		public Translate translate;
	}
}
