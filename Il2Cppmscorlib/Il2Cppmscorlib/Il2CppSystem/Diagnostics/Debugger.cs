using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics
{
	// Token: 0x020004A4 RID: 1188
	public sealed class Debugger : Object
	{
		// Token: 0x06004996 RID: 18838 RVA: 0x0015503C File Offset: 0x0015323C
		// Note: this type is marked as 'beforefieldinit'.
		static Debugger()
		{
			Il2CppClassPointerStore<Debugger>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics", "Debugger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Debugger>.NativeClassPtr);
			Debugger.NativeFieldInfoPtr_DefaultCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Debugger>.NativeClassPtr, "DefaultCategory");
			Debugger.NativeMethodInfoPtr_IsLogging_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debugger>.NativeClassPtr, 100674011);
			Debugger.NativeMethodInfoPtr_Log_icall_Private_Static_Void_Int32_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debugger>.NativeClassPtr, 100674012);
			Debugger.NativeMethodInfoPtr_Log_Public_Static_Void_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debugger>.NativeClassPtr, 100674013);
			Debugger.NativeMethodInfoPtr_NotifyOfCrossThreadDependency_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debugger>.NativeClassPtr, 100674014);
		}

		// Token: 0x06004997 RID: 18839 RVA: 0x001550D0 File Offset: 0x001532D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 429053, RefRangeEnd = 429054, XrefRangeStart = 429053, XrefRangeEnd = 429054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsLogging()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debugger.NativeMethodInfoPtr_IsLogging_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004998 RID: 18840 RVA: 0x00155100 File Offset: 0x00153300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Log_icall(int level, ref string category, ref string message)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref level;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(category);
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Debugger.NativeMethodInfoPtr_Log_icall_Private_Static_Void_Int32_byref_String_byref_String_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			category = IL2CPP.Il2CppStringToManaged(intPtr);
			message = IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x06004999 RID: 18841 RVA: 0x00155174 File Offset: 0x00153374
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1414266, RefRangeEnd = 1414267, XrefRangeStart = 1414262, XrefRangeEnd = 1414266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Log(int level, string category, string message)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref level;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(category);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debugger.NativeMethodInfoPtr_Log_Public_Static_Void_Int32_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600499A RID: 18842 RVA: 0x001551CC File Offset: 0x001533CC
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void NotifyOfCrossThreadDependency()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debugger.NativeMethodInfoPtr_NotifyOfCrossThreadDependency_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600499B RID: 18843 RVA: 0x0001AEF6 File Offset: 0x000190F6
		public Debugger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170012D1 RID: 4817
		// (get) Token: 0x0600499C RID: 18844 RVA: 0x001551F4 File Offset: 0x001533F4
		// (set) Token: 0x0600499D RID: 18845 RVA: 0x0001AEFF File Offset: 0x000190FF
		public unsafe static string DefaultCategory
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Debugger.NativeFieldInfoPtr_DefaultCategory, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Debugger.NativeFieldInfoPtr_DefaultCategory, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003C53 RID: 15443
		private static readonly IntPtr NativeFieldInfoPtr_DefaultCategory;

		// Token: 0x04003C54 RID: 15444
		private static readonly IntPtr NativeMethodInfoPtr_IsLogging_Public_Static_Boolean_0;

		// Token: 0x04003C55 RID: 15445
		private static readonly IntPtr NativeMethodInfoPtr_Log_icall_Private_Static_Void_Int32_byref_String_byref_String_0;

		// Token: 0x04003C56 RID: 15446
		private static readonly IntPtr NativeMethodInfoPtr_Log_Public_Static_Void_Int32_String_String_0;

		// Token: 0x04003C57 RID: 15447
		private static readonly IntPtr NativeMethodInfoPtr_NotifyOfCrossThreadDependency_Public_Static_Void_0;
	}
}
