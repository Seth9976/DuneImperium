using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001CE RID: 462
	[StructLayout(2)]
	public struct FriendsGroupID_t
	{
		// Token: 0x0600174F RID: 5967 RVA: 0x00072748 File Offset: 0x00070948
		// Note: this type is marked as 'beforefieldinit'.
		static FriendsGroupID_t()
		{
			Il2CppClassPointerStore<FriendsGroupID_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "FriendsGroupID_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendsGroupID_t>.NativeClassPtr);
			FriendsGroupID_t.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsGroupID_t>.NativeClassPtr, "Value");
			FriendsGroupID_t.NativeMethodInfoPtr_op_Implicit_Public_Static_FriendsGroupID_t_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsGroupID_t>.NativeClassPtr, 100667557);
			FriendsGroupID_t.NativeMethodInfoPtr_op_Implicit_Public_Static_Int16_FriendsGroupID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsGroupID_t>.NativeClassPtr, 100667558);
			FriendsGroupID_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsGroupID_t>.NativeClassPtr, 100667559);
			FriendsGroupID_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsGroupID_t>.NativeClassPtr, 100667560);
			FriendsGroupID_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsGroupID_t>.NativeClassPtr, 100667561);
			FriendsGroupID_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_FriendsGroupID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsGroupID_t>.NativeClassPtr, 100667562);
			FriendsGroupID_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_FriendsGroupID_t_FriendsGroupID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsGroupID_t>.NativeClassPtr, 100667563);
			FriendsGroupID_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_FriendsGroupID_t_FriendsGroupID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsGroupID_t>.NativeClassPtr, 100667564);
			FriendsGroupID_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_FriendsGroupID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsGroupID_t>.NativeClassPtr, 100667565);
		}

		// Token: 0x06001750 RID: 5968 RVA: 0x00072840 File Offset: 0x00070A40
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 630996, RefRangeEnd = 631003, XrefRangeStart = 630996, XrefRangeEnd = 631003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator FriendsGroupID_t(short value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsGroupID_t.NativeMethodInfoPtr_op_Implicit_Public_Static_FriendsGroupID_t_Int16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001751 RID: 5969 RVA: 0x00072880 File Offset: 0x00070A80
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 630996, RefRangeEnd = 631003, XrefRangeStart = 630996, XrefRangeEnd = 631003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator short(FriendsGroupID_t value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsGroupID_t.NativeMethodInfoPtr_op_Implicit_Public_Static_Int16_FriendsGroupID_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001752 RID: 5970 RVA: 0x000728C0 File Offset: 0x00070AC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951462, XrefRangeEnd = 951463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsGroupID_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001753 RID: 5971 RVA: 0x000728EC File Offset: 0x00070AEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951463, XrefRangeEnd = 951464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsGroupID_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001754 RID: 5972 RVA: 0x0007291C File Offset: 0x00070B1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951464, XrefRangeEnd = 951467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsGroupID_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001755 RID: 5973 RVA: 0x00072960 File Offset: 0x00070B60
		[CallerCount(0)]
		public unsafe bool Equals(FriendsGroupID_t p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsGroupID_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_FriendsGroupID_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001756 RID: 5974 RVA: 0x000729A0 File Offset: 0x00070BA0
		[CallerCount(0)]
		public unsafe static bool operator ==(FriendsGroupID_t a, FriendsGroupID_t b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsGroupID_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_FriendsGroupID_t_FriendsGroupID_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001757 RID: 5975 RVA: 0x000729EC File Offset: 0x00070BEC
		[CallerCount(0)]
		public unsafe static bool operator !=(FriendsGroupID_t a, FriendsGroupID_t b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsGroupID_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_FriendsGroupID_t_FriendsGroupID_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001758 RID: 5976 RVA: 0x00072A38 File Offset: 0x00070C38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951467, XrefRangeEnd = 951468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(FriendsGroupID_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsGroupID_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_FriendsGroupID_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001759 RID: 5977 RVA: 0x00007C29 File Offset: 0x00005E29
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FriendsGroupID_t>.NativeClassPtr, ref this));
		}

		// Token: 0x04001CBF RID: 7359
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x04001CC0 RID: 7360
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_FriendsGroupID_t_Int16_0;

		// Token: 0x04001CC1 RID: 7361
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Int16_FriendsGroupID_t_0;

		// Token: 0x04001CC2 RID: 7362
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001CC3 RID: 7363
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001CC4 RID: 7364
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001CC5 RID: 7365
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_FriendsGroupID_t_0;

		// Token: 0x04001CC6 RID: 7366
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_FriendsGroupID_t_FriendsGroupID_t_0;

		// Token: 0x04001CC7 RID: 7367
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_FriendsGroupID_t_FriendsGroupID_t_0;

		// Token: 0x04001CC8 RID: 7368
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_FriendsGroupID_t_0;

		// Token: 0x04001CC9 RID: 7369
		[FieldOffset(0)]
		public short Value;
	}
}
