using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Canis.data
{
	// Token: 0x0200014D RID: 333
	public class ClientVersionInfo : Object
	{
		// Token: 0x06000EB8 RID: 3768 RVA: 0x00057894 File Offset: 0x00055A94
		// Note: this type is marked as 'beforefieldinit'.
		static ClientVersionInfo()
		{
			Il2CppClassPointerStore<ClientVersionInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.data", "ClientVersionInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientVersionInfo>.NativeClassPtr);
			ClientVersionInfo.NativeFieldInfoPtr_Major = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientVersionInfo>.NativeClassPtr, "Major");
			ClientVersionInfo.NativeFieldInfoPtr_Minor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientVersionInfo>.NativeClassPtr, "Minor");
			ClientVersionInfo.NativeFieldInfoPtr_Hotfix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientVersionInfo>.NativeClassPtr, "Hotfix");
			ClientVersionInfo.NativeFieldInfoPtr_Build = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientVersionInfo>.NativeClassPtr, "Build");
			ClientVersionInfo.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientVersionInfo>.NativeClassPtr, 100666501);
			ClientVersionInfo.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_ClientVersionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientVersionInfo>.NativeClassPtr, 100666502);
			ClientVersionInfo.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ClientVersionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientVersionInfo>.NativeClassPtr, 100666503);
			ClientVersionInfo.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ClientVersionInfo_ClientVersionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientVersionInfo>.NativeClassPtr, 100666504);
			ClientVersionInfo.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ClientVersionInfo_ClientVersionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientVersionInfo>.NativeClassPtr, 100666505);
			ClientVersionInfo.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_ClientVersionInfo_ClientVersionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientVersionInfo>.NativeClassPtr, 100666506);
			ClientVersionInfo.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_ClientVersionInfo_ClientVersionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientVersionInfo>.NativeClassPtr, 100666507);
			ClientVersionInfo.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_ClientVersionInfo_ClientVersionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientVersionInfo>.NativeClassPtr, 100666508);
			ClientVersionInfo.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_ClientVersionInfo_ClientVersionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientVersionInfo>.NativeClassPtr, 100666509);
			ClientVersionInfo.NativeMethodInfoPtr_Equals_Protected_Boolean_ClientVersionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientVersionInfo>.NativeClassPtr, 100666510);
			ClientVersionInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientVersionInfo>.NativeClassPtr, 100666511);
			ClientVersionInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientVersionInfo>.NativeClassPtr, 100666512);
		}

		// Token: 0x06000EB9 RID: 3769 RVA: 0x00057A04 File Offset: 0x00055C04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577854, XrefRangeEnd = 577855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClientVersionInfo(int major, int minor, int hotfix, int build)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientVersionInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref major;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hotfix;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref build;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientVersionInfo.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EBA RID: 3770 RVA: 0x00057A78 File Offset: 0x00055C78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 577882, RefRangeEnd = 577883, XrefRangeStart = 577855, XrefRangeEnd = 577882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParse(string clientVersion, out ClientVersionInfo versionInfo)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(clientVersion);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ClientVersionInfo.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_ClientVersionInfo_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			versionInfo = ((intPtr4 == 0) ? null : new ClientVersionInfo(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000EBB RID: 3771 RVA: 0x00057ADC File Offset: 0x00055CDC
		[CallerCount(0)]
		public unsafe virtual int CompareTo(ClientVersionInfo other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientVersionInfo.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ClientVersionInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EBC RID: 3772 RVA: 0x00057B2C File Offset: 0x00055D2C
		[CallerCount(0)]
		public unsafe static bool operator ==(ClientVersionInfo a, ClientVersionInfo b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientVersionInfo.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ClientVersionInfo_ClientVersionInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EBD RID: 3773 RVA: 0x00057B80 File Offset: 0x00055D80
		[CallerCount(0)]
		public unsafe static bool operator !=(ClientVersionInfo a, ClientVersionInfo b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientVersionInfo.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ClientVersionInfo_ClientVersionInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EBE RID: 3774 RVA: 0x00057BD4 File Offset: 0x00055DD4
		[CallerCount(0)]
		public unsafe static bool operator <=(ClientVersionInfo a, ClientVersionInfo b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientVersionInfo.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_ClientVersionInfo_ClientVersionInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EBF RID: 3775 RVA: 0x00057C28 File Offset: 0x00055E28
		[CallerCount(0)]
		public unsafe static bool operator >=(ClientVersionInfo a, ClientVersionInfo b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientVersionInfo.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_ClientVersionInfo_ClientVersionInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EC0 RID: 3776 RVA: 0x00057C7C File Offset: 0x00055E7C
		[CallerCount(0)]
		public unsafe static bool operator <(ClientVersionInfo a, ClientVersionInfo b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientVersionInfo.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_ClientVersionInfo_ClientVersionInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EC1 RID: 3777 RVA: 0x00057CD0 File Offset: 0x00055ED0
		[CallerCount(0)]
		public unsafe static bool operator >(ClientVersionInfo a, ClientVersionInfo b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientVersionInfo.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_ClientVersionInfo_ClientVersionInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EC2 RID: 3778 RVA: 0x00057D24 File Offset: 0x00055F24
		[CallerCount(0)]
		public unsafe bool Equals(ClientVersionInfo other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientVersionInfo.NativeMethodInfoPtr_Equals_Protected_Boolean_ClientVersionInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EC3 RID: 3779 RVA: 0x00057D74 File Offset: 0x00055F74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577883, XrefRangeEnd = 577891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClientVersionInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EC4 RID: 3780 RVA: 0x00057DCC File Offset: 0x00055FCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577891, XrefRangeEnd = 577897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClientVersionInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EC5 RID: 3781 RVA: 0x0000764B File Offset: 0x0000584B
		public ClientVersionInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000EC6 RID: 3782 RVA: 0x00057E14 File Offset: 0x00056014
		// (set) Token: 0x06000EC7 RID: 3783 RVA: 0x00007654 File Offset: 0x00005854
		public unsafe int Major
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientVersionInfo.NativeFieldInfoPtr_Major);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientVersionInfo.NativeFieldInfoPtr_Major)) = value;
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000EC8 RID: 3784 RVA: 0x00057E3C File Offset: 0x0005603C
		// (set) Token: 0x06000EC9 RID: 3785 RVA: 0x0000766F File Offset: 0x0000586F
		public unsafe int Minor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientVersionInfo.NativeFieldInfoPtr_Minor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientVersionInfo.NativeFieldInfoPtr_Minor)) = value;
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000ECA RID: 3786 RVA: 0x00057E64 File Offset: 0x00056064
		// (set) Token: 0x06000ECB RID: 3787 RVA: 0x0000768A File Offset: 0x0000588A
		public unsafe int Hotfix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientVersionInfo.NativeFieldInfoPtr_Hotfix);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientVersionInfo.NativeFieldInfoPtr_Hotfix)) = value;
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000ECC RID: 3788 RVA: 0x00057E8C File Offset: 0x0005608C
		// (set) Token: 0x06000ECD RID: 3789 RVA: 0x000076A5 File Offset: 0x000058A5
		public unsafe int Build
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientVersionInfo.NativeFieldInfoPtr_Build);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientVersionInfo.NativeFieldInfoPtr_Build)) = value;
			}
		}

		// Token: 0x040009E9 RID: 2537
		private static readonly IntPtr NativeFieldInfoPtr_Major;

		// Token: 0x040009EA RID: 2538
		private static readonly IntPtr NativeFieldInfoPtr_Minor;

		// Token: 0x040009EB RID: 2539
		private static readonly IntPtr NativeFieldInfoPtr_Hotfix;

		// Token: 0x040009EC RID: 2540
		private static readonly IntPtr NativeFieldInfoPtr_Build;

		// Token: 0x040009ED RID: 2541
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0;

		// Token: 0x040009EE RID: 2542
		private static readonly IntPtr NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_ClientVersionInfo_0;

		// Token: 0x040009EF RID: 2543
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ClientVersionInfo_0;

		// Token: 0x040009F0 RID: 2544
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ClientVersionInfo_ClientVersionInfo_0;

		// Token: 0x040009F1 RID: 2545
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ClientVersionInfo_ClientVersionInfo_0;

		// Token: 0x040009F2 RID: 2546
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_ClientVersionInfo_ClientVersionInfo_0;

		// Token: 0x040009F3 RID: 2547
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_ClientVersionInfo_ClientVersionInfo_0;

		// Token: 0x040009F4 RID: 2548
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_ClientVersionInfo_ClientVersionInfo_0;

		// Token: 0x040009F5 RID: 2549
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_ClientVersionInfo_ClientVersionInfo_0;

		// Token: 0x040009F6 RID: 2550
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Protected_Boolean_ClientVersionInfo_0;

		// Token: 0x040009F7 RID: 2551
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040009F8 RID: 2552
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
