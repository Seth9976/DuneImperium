using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x02000206 RID: 518
	public sealed class ListenerPrefix : Object
	{
		// Token: 0x060021BA RID: 8634 RVA: 0x0009DFC0 File Offset: 0x0009C1C0
		// Note: this type is marked as 'beforefieldinit'.
		static ListenerPrefix()
		{
			Il2CppClassPointerStore<ListenerPrefix>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "ListenerPrefix");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListenerPrefix>.NativeClassPtr);
			ListenerPrefix.NativeFieldInfoPtr_original = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerPrefix>.NativeClassPtr, "original");
			ListenerPrefix.NativeFieldInfoPtr_host = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerPrefix>.NativeClassPtr, "host");
			ListenerPrefix.NativeFieldInfoPtr_port = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerPrefix>.NativeClassPtr, "port");
			ListenerPrefix.NativeFieldInfoPtr_path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerPrefix>.NativeClassPtr, "path");
			ListenerPrefix.NativeFieldInfoPtr_secure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerPrefix>.NativeClassPtr, "secure");
			ListenerPrefix.NativeFieldInfoPtr_Listener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerPrefix>.NativeClassPtr, "Listener");
			ListenerPrefix.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerPrefix>.NativeClassPtr, 100668316);
			ListenerPrefix.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerPrefix>.NativeClassPtr, 100668317);
			ListenerPrefix.NativeMethodInfoPtr_get_Secure_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerPrefix>.NativeClassPtr, 100668318);
			ListenerPrefix.NativeMethodInfoPtr_get_Host_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerPrefix>.NativeClassPtr, 100668319);
			ListenerPrefix.NativeMethodInfoPtr_get_Port_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerPrefix>.NativeClassPtr, 100668320);
			ListenerPrefix.NativeMethodInfoPtr_get_Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerPrefix>.NativeClassPtr, 100668321);
			ListenerPrefix.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerPrefix>.NativeClassPtr, 100668322);
			ListenerPrefix.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerPrefix>.NativeClassPtr, 100668323);
			ListenerPrefix.NativeMethodInfoPtr_Parse_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerPrefix>.NativeClassPtr, 100668324);
			ListenerPrefix.NativeMethodInfoPtr_CheckUri_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerPrefix>.NativeClassPtr, 100668325);
		}

		// Token: 0x060021BB RID: 8635 RVA: 0x0009E130 File Offset: 0x0009C330
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 482646, RefRangeEnd = 482648, XrefRangeStart = 482643, XrefRangeEnd = 482646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ListenerPrefix(string prefix)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListenerPrefix>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListenerPrefix.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021BC RID: 8636 RVA: 0x0009E17C File Offset: 0x0009C37C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListenerPrefix.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17000A92 RID: 2706
		// (get) Token: 0x060021BD RID: 8637 RVA: 0x0009E1B4 File Offset: 0x0009C3B4
		public unsafe bool Secure
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListenerPrefix.NativeMethodInfoPtr_get_Secure_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A93 RID: 2707
		// (get) Token: 0x060021BE RID: 8638 RVA: 0x0009E1F0 File Offset: 0x0009C3F0
		public unsafe string Host
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListenerPrefix.NativeMethodInfoPtr_get_Host_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000A94 RID: 2708
		// (get) Token: 0x060021BF RID: 8639 RVA: 0x0009E228 File Offset: 0x0009C428
		public unsafe int Port
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListenerPrefix.NativeMethodInfoPtr_get_Port_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A95 RID: 2709
		// (get) Token: 0x060021C0 RID: 8640 RVA: 0x0009E264 File Offset: 0x0009C464
		public unsafe string Path
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListenerPrefix.NativeMethodInfoPtr_get_Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060021C1 RID: 8641 RVA: 0x0009E29C File Offset: 0x0009C49C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482648, XrefRangeEnd = 482651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListenerPrefix.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060021C2 RID: 8642 RVA: 0x0009E2EC File Offset: 0x0009C4EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListenerPrefix.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021C3 RID: 8643 RVA: 0x0009E328 File Offset: 0x0009C528
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 482679, RefRangeEnd = 482680, XrefRangeStart = 482651, XrefRangeEnd = 482679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Parse(string uri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListenerPrefix.NativeMethodInfoPtr_Parse_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021C4 RID: 8644 RVA: 0x0009E36C File Offset: 0x0009C56C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 482696, RefRangeEnd = 482697, XrefRangeStart = 482680, XrefRangeEnd = 482696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckUri(string uri)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListenerPrefix.NativeMethodInfoPtr_CheckUri_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021C5 RID: 8645 RVA: 0x0000E96D File Offset: 0x0000CB6D
		public ListenerPrefix(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A8C RID: 2700
		// (get) Token: 0x060021C6 RID: 8646 RVA: 0x0009E3A4 File Offset: 0x0009C5A4
		// (set) Token: 0x060021C7 RID: 8647 RVA: 0x0000E976 File Offset: 0x0000CB76
		public unsafe string original
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerPrefix.NativeFieldInfoPtr_original);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerPrefix.NativeFieldInfoPtr_original), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A8D RID: 2701
		// (get) Token: 0x060021C8 RID: 8648 RVA: 0x0009E3CC File Offset: 0x0009C5CC
		// (set) Token: 0x060021C9 RID: 8649 RVA: 0x0000E995 File Offset: 0x0000CB95
		public unsafe string host
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerPrefix.NativeFieldInfoPtr_host);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerPrefix.NativeFieldInfoPtr_host), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A8E RID: 2702
		// (get) Token: 0x060021CA RID: 8650 RVA: 0x0009E3F4 File Offset: 0x0009C5F4
		// (set) Token: 0x060021CB RID: 8651 RVA: 0x0000E9B4 File Offset: 0x0000CBB4
		public unsafe ushort port
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerPrefix.NativeFieldInfoPtr_port);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerPrefix.NativeFieldInfoPtr_port)) = value;
			}
		}

		// Token: 0x17000A8F RID: 2703
		// (get) Token: 0x060021CC RID: 8652 RVA: 0x0009E41C File Offset: 0x0009C61C
		// (set) Token: 0x060021CD RID: 8653 RVA: 0x0000E9CF File Offset: 0x0000CBCF
		public unsafe string path
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerPrefix.NativeFieldInfoPtr_path);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerPrefix.NativeFieldInfoPtr_path), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A90 RID: 2704
		// (get) Token: 0x060021CE RID: 8654 RVA: 0x0009E444 File Offset: 0x0009C644
		// (set) Token: 0x060021CF RID: 8655 RVA: 0x0000E9EE File Offset: 0x0000CBEE
		public unsafe bool secure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerPrefix.NativeFieldInfoPtr_secure);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerPrefix.NativeFieldInfoPtr_secure)) = value;
			}
		}

		// Token: 0x17000A91 RID: 2705
		// (get) Token: 0x060021D0 RID: 8656 RVA: 0x0009E46C File Offset: 0x0009C66C
		// (set) Token: 0x060021D1 RID: 8657 RVA: 0x0000EA09 File Offset: 0x0000CC09
		public unsafe HttpListener Listener
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerPrefix.NativeFieldInfoPtr_Listener);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpListener>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerPrefix.NativeFieldInfoPtr_Listener), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A4D RID: 6733
		private static readonly IntPtr NativeFieldInfoPtr_original;

		// Token: 0x04001A4E RID: 6734
		private static readonly IntPtr NativeFieldInfoPtr_host;

		// Token: 0x04001A4F RID: 6735
		private static readonly IntPtr NativeFieldInfoPtr_port;

		// Token: 0x04001A50 RID: 6736
		private static readonly IntPtr NativeFieldInfoPtr_path;

		// Token: 0x04001A51 RID: 6737
		private static readonly IntPtr NativeFieldInfoPtr_secure;

		// Token: 0x04001A52 RID: 6738
		private static readonly IntPtr NativeFieldInfoPtr_Listener;

		// Token: 0x04001A53 RID: 6739
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04001A54 RID: 6740
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001A55 RID: 6741
		private static readonly IntPtr NativeMethodInfoPtr_get_Secure_Public_get_Boolean_0;

		// Token: 0x04001A56 RID: 6742
		private static readonly IntPtr NativeMethodInfoPtr_get_Host_Public_get_String_0;

		// Token: 0x04001A57 RID: 6743
		private static readonly IntPtr NativeMethodInfoPtr_get_Port_Public_get_Int32_0;

		// Token: 0x04001A58 RID: 6744
		private static readonly IntPtr NativeMethodInfoPtr_get_Path_Public_get_String_0;

		// Token: 0x04001A59 RID: 6745
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001A5A RID: 6746
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001A5B RID: 6747
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Private_Void_String_0;

		// Token: 0x04001A5C RID: 6748
		private static readonly IntPtr NativeMethodInfoPtr_CheckUri_Public_Static_Void_String_0;
	}
}
