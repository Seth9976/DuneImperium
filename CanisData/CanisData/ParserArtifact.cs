using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace CanisData
{
	// Token: 0x02000009 RID: 9
	public class ParserArtifact : Object
	{
		// Token: 0x06000022 RID: 34 RVA: 0x00003E68 File Offset: 0x00002068
		// Note: this type is marked as 'beforefieldinit'.
		static ParserArtifact()
		{
			Il2CppClassPointerStore<ParserArtifact>.NativeClassPtr = IL2CPP.GetIl2CppClass("CanisData.dll", "CanisData", "ParserArtifact");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParserArtifact>.NativeClassPtr);
			ParserArtifact.NativeFieldInfoPtr__RelativePathName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParserArtifact>.NativeClassPtr, "<RelativePathName>k__BackingField");
			ParserArtifact.NativeFieldInfoPtr__Contents_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParserArtifact>.NativeClassPtr, "<Contents>k__BackingField");
			ParserArtifact.NativeMethodInfoPtr_get_RelativePathName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParserArtifact>.NativeClassPtr, 100663311);
			ParserArtifact.NativeMethodInfoPtr_get_Contents_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParserArtifact>.NativeClassPtr, 100663312);
			ParserArtifact.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParserArtifact>.NativeClassPtr, 100663313);
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00003EFC File Offset: 0x000020FC
		public unsafe string RelativePathName
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParserArtifact.NativeMethodInfoPtr_get_RelativePathName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00003F34 File Offset: 0x00002134
		public unsafe string Contents
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParserArtifact.NativeMethodInfoPtr_get_Contents_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00003F6C File Offset: 0x0000216C
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296744, XrefRangeEnd = 296798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParserArtifact(string relativePathName, string contents)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParserArtifact>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(relativePathName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(contents);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParserArtifact.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002186 File Offset: 0x00000386
		public ParserArtifact(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00003FCC File Offset: 0x000021CC
		// (set) Token: 0x06000028 RID: 40 RVA: 0x0000218F File Offset: 0x0000038F
		public unsafe string _RelativePathName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParserArtifact.NativeFieldInfoPtr__RelativePathName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParserArtifact.NativeFieldInfoPtr__RelativePathName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00003FF4 File Offset: 0x000021F4
		// (set) Token: 0x0600002A RID: 42 RVA: 0x000021AE File Offset: 0x000003AE
		public unsafe string _Contents_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParserArtifact.NativeFieldInfoPtr__Contents_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParserArtifact.NativeFieldInfoPtr__Contents_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeFieldInfoPtr__RelativePathName_k__BackingField;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeFieldInfoPtr__Contents_k__BackingField;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr_get_RelativePathName_Public_get_String_0;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr_get_Contents_Public_get_String_0;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;
	}
}
