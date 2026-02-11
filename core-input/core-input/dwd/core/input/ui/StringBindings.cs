using System;
using dwd.core.input.compositeModule.inputDetection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.input.ui
{
	// Token: 0x0200005D RID: 93
	public class StringBindings : Object
	{
		// Token: 0x06000372 RID: 882 RVA: 0x00011930 File Offset: 0x0000FB30
		// Note: this type is marked as 'beforefieldinit'.
		static StringBindings()
		{
			Il2CppClassPointerStore<StringBindings>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.ui", "StringBindings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringBindings>.NativeClassPtr);
			StringBindings.NativeFieldInfoPtr_KeyBindingStrings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringBindings>.NativeClassPtr, "KeyBindingStrings");
			StringBindings.NativeFieldInfoPtr_MouseBindingStrings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringBindings>.NativeClassPtr, "MouseBindingStrings");
			StringBindings.NativeFieldInfoPtr_DeviceBindingStrings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringBindings>.NativeClassPtr, "DeviceBindingStrings");
			StringBindings.NativeMethodInfoPtr__ctor_Public_Void_String_InputDetector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBindings>.NativeClassPtr, 100663687);
		}

		// Token: 0x06000373 RID: 883 RVA: 0x000119B0 File Offset: 0x0000FBB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121689, XrefRangeEnd = 1121694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBindings(string id, InputDetector detector)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringBindings>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(detector);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBindings.NativeMethodInfoPtr__ctor_Public_Void_String_InputDetector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000374 RID: 884 RVA: 0x00004001 File Offset: 0x00002201
		public StringBindings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000375 RID: 885 RVA: 0x00011A10 File Offset: 0x0000FC10
		// (set) Token: 0x06000376 RID: 886 RVA: 0x0000400A File Offset: 0x0000220A
		public unsafe Il2CppStringArray KeyBindingStrings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringBindings.NativeFieldInfoPtr_KeyBindingStrings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringBindings.NativeFieldInfoPtr_KeyBindingStrings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000377 RID: 887 RVA: 0x00011A40 File Offset: 0x0000FC40
		// (set) Token: 0x06000378 RID: 888 RVA: 0x00004029 File Offset: 0x00002229
		public unsafe Il2CppStringArray MouseBindingStrings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringBindings.NativeFieldInfoPtr_MouseBindingStrings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringBindings.NativeFieldInfoPtr_MouseBindingStrings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000379 RID: 889 RVA: 0x00011A70 File Offset: 0x0000FC70
		// (set) Token: 0x0600037A RID: 890 RVA: 0x00004048 File Offset: 0x00002248
		public unsafe Il2CppStringArray DeviceBindingStrings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringBindings.NativeFieldInfoPtr_DeviceBindingStrings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringBindings.NativeFieldInfoPtr_DeviceBindingStrings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000204 RID: 516
		private static readonly IntPtr NativeFieldInfoPtr_KeyBindingStrings;

		// Token: 0x04000205 RID: 517
		private static readonly IntPtr NativeFieldInfoPtr_MouseBindingStrings;

		// Token: 0x04000206 RID: 518
		private static readonly IntPtr NativeFieldInfoPtr_DeviceBindingStrings;

		// Token: 0x04000207 RID: 519
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_InputDetector_0;
	}
}
