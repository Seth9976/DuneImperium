using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000087 RID: 135
	[Serializable]
	public class RectOffset : Object
	{
		// Token: 0x06000754 RID: 1876 RVA: 0x0002E730 File Offset: 0x0002C930
		// Note: this type is marked as 'beforefieldinit'.
		static RectOffset()
		{
			Il2CppClassPointerStore<RectOffset>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "RectOffset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RectOffset>.NativeClassPtr);
			RectOffset.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, "m_Ptr");
			RectOffset.NativeFieldInfoPtr_m_SourceStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, "m_SourceStyle");
			RectOffset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664210);
			RectOffset.NativeMethodInfoPtr__ctor_Internal_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664211);
			RectOffset.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664212);
			RectOffset.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664213);
			RectOffset.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664214);
			RectOffset.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664215);
			RectOffset.NativeMethodInfoPtr_Destroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664216);
			RectOffset.NativeMethodInfoPtr_InternalCreate_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664217);
			RectOffset.NativeMethodInfoPtr_InternalDestroy_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664218);
			RectOffset.NativeMethodInfoPtr_get_left_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664219);
			RectOffset.NativeMethodInfoPtr_set_left_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664220);
			RectOffset.NativeMethodInfoPtr_get_right_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664221);
			RectOffset.NativeMethodInfoPtr_set_right_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664222);
			RectOffset.NativeMethodInfoPtr_get_top_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664223);
			RectOffset.NativeMethodInfoPtr_set_top_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664224);
			RectOffset.NativeMethodInfoPtr_get_bottom_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664225);
			RectOffset.NativeMethodInfoPtr_set_bottom_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664226);
			RectOffset.NativeMethodInfoPtr_get_horizontal_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664227);
			RectOffset.NativeMethodInfoPtr_get_vertical_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664228);
			RectOffset.Add_InjectedDelegateField = IL2CPP.ResolveICall<RectOffset.Add_InjectedDelegate>("UnityEngine.RectOffset::Add_Injected");
			RectOffset.Remove_InjectedDelegateField = IL2CPP.ResolveICall<RectOffset.Remove_InjectedDelegate>("UnityEngine.RectOffset::Remove_Injected");
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x0002E924 File Offset: 0x0002CB24
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 648873, RefRangeEnd = 648876, XrefRangeStart = 648870, XrefRangeEnd = 648873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RectOffset()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RectOffset>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x0002E960 File Offset: 0x0002CB60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 648878, RefRangeEnd = 648880, XrefRangeStart = 648876, XrefRangeEnd = 648878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RectOffset(Object sourceStyle, IntPtr source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RectOffset>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceStyle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref source;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr__ctor_Internal_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x0002E9BC File Offset: 0x0002CBBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 648880, XrefRangeEnd = 648886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RectOffset.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x0002E9F8 File Offset: 0x0002CBF8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 648897, RefRangeEnd = 648900, XrefRangeStart = 648886, XrefRangeEnd = 648897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RectOffset(int left, int right, int top, int bottom)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RectOffset>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x0002EA6C File Offset: 0x0002CC6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 648900, XrefRangeEnd = 648901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RectOffset.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x0002EAB0 File Offset: 0x0002CCB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 648901, XrefRangeEnd = 648931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string ToString(string format, IFormatProvider formatProvider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x0002EB0C File Offset: 0x0002CD0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 648931, XrefRangeEnd = 648934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr_Destroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x0002EB40 File Offset: 0x0002CD40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 648934, XrefRangeEnd = 648936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr InternalCreate()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr_InternalCreate_Private_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x0002EB70 File Offset: 0x0002CD70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 648936, XrefRangeEnd = 648938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InternalDestroy(IntPtr ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr_InternalDestroy_Private_Static_Void_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x0600075E RID: 1886 RVA: 0x0002EBA4 File Offset: 0x0002CDA4
		// (set) Token: 0x0600075F RID: 1887 RVA: 0x0002EBE0 File Offset: 0x0002CDE0
		public unsafe int left
		{
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 648940, RefRangeEnd = 648965, XrefRangeStart = 648938, XrefRangeEnd = 648940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr_get_left_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 648967, RefRangeEnd = 648974, XrefRangeStart = 648965, XrefRangeEnd = 648967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr_set_left_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000760 RID: 1888 RVA: 0x0002EC20 File Offset: 0x0002CE20
		// (set) Token: 0x06000761 RID: 1889 RVA: 0x0002EC5C File Offset: 0x0002CE5C
		public unsafe int right
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 648976, RefRangeEnd = 648996, XrefRangeStart = 648974, XrefRangeEnd = 648976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr_get_right_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 648998, RefRangeEnd = 649003, XrefRangeStart = 648996, XrefRangeEnd = 648998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr_set_right_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000762 RID: 1890 RVA: 0x0002EC9C File Offset: 0x0002CE9C
		// (set) Token: 0x06000763 RID: 1891 RVA: 0x0002ECD8 File Offset: 0x0002CED8
		public unsafe int top
		{
			[CallerCount(26)]
			[CachedScanResults(RefRangeStart = 649005, RefRangeEnd = 649031, XrefRangeStart = 649003, XrefRangeEnd = 649005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr_get_top_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 649033, RefRangeEnd = 649038, XrefRangeStart = 649031, XrefRangeEnd = 649033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr_set_top_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000764 RID: 1892 RVA: 0x0002ED18 File Offset: 0x0002CF18
		// (set) Token: 0x06000765 RID: 1893 RVA: 0x0002ED54 File Offset: 0x0002CF54
		public unsafe int bottom
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 649040, RefRangeEnd = 649059, XrefRangeStart = 649038, XrefRangeEnd = 649040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr_get_bottom_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 649061, RefRangeEnd = 649066, XrefRangeStart = 649059, XrefRangeEnd = 649061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr_set_bottom_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000766 RID: 1894 RVA: 0x0002ED94 File Offset: 0x0002CF94
		public unsafe int horizontal
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 649068, RefRangeEnd = 649087, XrefRangeStart = 649066, XrefRangeEnd = 649068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr_get_horizontal_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000767 RID: 1895 RVA: 0x0002EDD0 File Offset: 0x0002CFD0
		public unsafe int vertical
		{
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 649089, RefRangeEnd = 649106, XrefRangeStart = 649087, XrefRangeEnd = 649089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr_get_vertical_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x00004C81 File Offset: 0x00002E81
		public RectOffset(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000769 RID: 1897 RVA: 0x0002EE0C File Offset: 0x0002D00C
		// (set) Token: 0x0600076A RID: 1898 RVA: 0x00004C8A File Offset: 0x00002E8A
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectOffset.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectOffset.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x0600076B RID: 1899 RVA: 0x0002EE34 File Offset: 0x0002D034
		// (set) Token: 0x0600076C RID: 1900 RVA: 0x00004CA5 File Offset: 0x00002EA5
		public unsafe Object m_SourceStyle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectOffset.NativeFieldInfoPtr_m_SourceStyle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectOffset.NativeFieldInfoPtr_m_SourceStyle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x0002EE64 File Offset: 0x0002D064
		public string ToString(string format)
		{
			return this.ToString(format, null);
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x0002EE80 File Offset: 0x0002D080
		public Rect Add(Rect rect)
		{
			Rect rect2;
			this.Add_Injected(ref rect, out rect2);
			return rect2;
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x0002EE98 File Offset: 0x0002D098
		public Rect Remove(Rect rect)
		{
			Rect rect2;
			this.Remove_Injected(ref rect, out rect2);
			return rect2;
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x00004CC4 File Offset: 0x00002EC4
		public void Add_Injected(ref Rect rect, out Rect ret)
		{
			RectOffset.Add_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref rect, out ret);
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x00004CD8 File Offset: 0x00002ED8
		public void Remove_Injected(ref Rect rect, out Rect ret)
		{
			RectOffset.Remove_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref rect, out ret);
		}

		// Token: 0x0400061F RID: 1567
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x04000620 RID: 1568
		private static readonly IntPtr NativeFieldInfoPtr_m_SourceStyle;

		// Token: 0x04000621 RID: 1569
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000622 RID: 1570
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Object_IntPtr_0;

		// Token: 0x04000623 RID: 1571
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04000624 RID: 1572
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0;

		// Token: 0x04000625 RID: 1573
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000626 RID: 1574
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04000627 RID: 1575
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Private_Void_0;

		// Token: 0x04000628 RID: 1576
		private static readonly IntPtr NativeMethodInfoPtr_InternalCreate_Private_Static_IntPtr_0;

		// Token: 0x04000629 RID: 1577
		private static readonly IntPtr NativeMethodInfoPtr_InternalDestroy_Private_Static_Void_IntPtr_0;

		// Token: 0x0400062A RID: 1578
		private static readonly IntPtr NativeMethodInfoPtr_get_left_Public_get_Int32_0;

		// Token: 0x0400062B RID: 1579
		private static readonly IntPtr NativeMethodInfoPtr_set_left_Public_set_Void_Int32_0;

		// Token: 0x0400062C RID: 1580
		private static readonly IntPtr NativeMethodInfoPtr_get_right_Public_get_Int32_0;

		// Token: 0x0400062D RID: 1581
		private static readonly IntPtr NativeMethodInfoPtr_set_right_Public_set_Void_Int32_0;

		// Token: 0x0400062E RID: 1582
		private static readonly IntPtr NativeMethodInfoPtr_get_top_Public_get_Int32_0;

		// Token: 0x0400062F RID: 1583
		private static readonly IntPtr NativeMethodInfoPtr_set_top_Public_set_Void_Int32_0;

		// Token: 0x04000630 RID: 1584
		private static readonly IntPtr NativeMethodInfoPtr_get_bottom_Public_get_Int32_0;

		// Token: 0x04000631 RID: 1585
		private static readonly IntPtr NativeMethodInfoPtr_set_bottom_Public_set_Void_Int32_0;

		// Token: 0x04000632 RID: 1586
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontal_Public_get_Int32_0;

		// Token: 0x04000633 RID: 1587
		private static readonly IntPtr NativeMethodInfoPtr_get_vertical_Public_get_Int32_0;

		// Token: 0x04000634 RID: 1588
		private static readonly RectOffset.Add_InjectedDelegate Add_InjectedDelegateField;

		// Token: 0x04000635 RID: 1589
		private static readonly RectOffset.Remove_InjectedDelegate Remove_InjectedDelegateField;

		// Token: 0x020004AC RID: 1196
		// (Invoke) Token: 0x0600325F RID: 12895
		private delegate void Add_InjectedDelegate(IntPtr @this, IntPtr rect, [Out] IntPtr ret);

		// Token: 0x020004AD RID: 1197
		// (Invoke) Token: 0x06003261 RID: 12897
		private delegate void Remove_InjectedDelegate(IntPtr @this, IntPtr rect, [Out] IntPtr ret);
	}
}
