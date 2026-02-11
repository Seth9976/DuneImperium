using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem
{
	// Token: 0x020000DD RID: 221
	public class ResolveEventArgs : EventArgs
	{
		// Token: 0x06000E4E RID: 3662 RVA: 0x00068A94 File Offset: 0x00066C94
		// Note: this type is marked as 'beforefieldinit'.
		static ResolveEventArgs()
		{
			Il2CppClassPointerStore<ResolveEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ResolveEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResolveEventArgs>.NativeClassPtr);
			ResolveEventArgs.NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveEventArgs>.NativeClassPtr, "<Name>k__BackingField");
			ResolveEventArgs.NativeFieldInfoPtr__RequestingAssembly_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveEventArgs>.NativeClassPtr, "<RequestingAssembly>k__BackingField");
			ResolveEventArgs.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveEventArgs>.NativeClassPtr, 100665799);
			ResolveEventArgs.NativeMethodInfoPtr__ctor_Public_Void_String_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveEventArgs>.NativeClassPtr, 100665800);
			ResolveEventArgs.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveEventArgs>.NativeClassPtr, 100665801);
		}

		// Token: 0x06000E4F RID: 3663 RVA: 0x00068B28 File Offset: 0x00066D28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1319099, RefRangeEnd = 1319100, XrefRangeStart = 1319094, XrefRangeEnd = 1319099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResolveEventArgs(string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResolveEventArgs>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveEventArgs.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E50 RID: 3664 RVA: 0x00068B74 File Offset: 0x00066D74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1319106, RefRangeEnd = 1319108, XrefRangeStart = 1319100, XrefRangeEnd = 1319106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResolveEventArgs(string name, Assembly requestingAssembly)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResolveEventArgs>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(requestingAssembly);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveEventArgs.NativeMethodInfoPtr__ctor_Public_Void_String_Assembly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06000E51 RID: 3665 RVA: 0x00068BD4 File Offset: 0x00066DD4
		public unsafe string Name
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveEventArgs.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000E52 RID: 3666 RVA: 0x0000578B File Offset: 0x0000398B
		public ResolveEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06000E53 RID: 3667 RVA: 0x00068C0C File Offset: 0x00066E0C
		// (set) Token: 0x06000E54 RID: 3668 RVA: 0x00005794 File Offset: 0x00003994
		public unsafe string _Name_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveEventArgs.NativeFieldInfoPtr__Name_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveEventArgs.NativeFieldInfoPtr__Name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06000E55 RID: 3669 RVA: 0x00068C34 File Offset: 0x00066E34
		// (set) Token: 0x06000E56 RID: 3670 RVA: 0x000057B3 File Offset: 0x000039B3
		public unsafe Assembly _RequestingAssembly_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveEventArgs.NativeFieldInfoPtr__RequestingAssembly_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveEventArgs.NativeFieldInfoPtr__RequestingAssembly_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BAF RID: 2991
		private static readonly IntPtr NativeFieldInfoPtr__Name_k__BackingField;

		// Token: 0x04000BB0 RID: 2992
		private static readonly IntPtr NativeFieldInfoPtr__RequestingAssembly_k__BackingField;

		// Token: 0x04000BB1 RID: 2993
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000BB2 RID: 2994
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Assembly_0;

		// Token: 0x04000BB3 RID: 2995
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;
	}
}
