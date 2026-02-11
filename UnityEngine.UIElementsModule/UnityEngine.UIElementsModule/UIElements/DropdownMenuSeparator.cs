using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x020000B8 RID: 184
	public class DropdownMenuSeparator : DropdownMenuItem
	{
		// Token: 0x0600111E RID: 4382 RVA: 0x00059140 File Offset: 0x00057340
		// Note: this type is marked as 'beforefieldinit'.
		static DropdownMenuSeparator()
		{
			Il2CppClassPointerStore<DropdownMenuSeparator>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "DropdownMenuSeparator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DropdownMenuSeparator>.NativeClassPtr);
			DropdownMenuSeparator.NativeFieldInfoPtr__subMenuPath_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropdownMenuSeparator>.NativeClassPtr, "<subMenuPath>k__BackingField");
			DropdownMenuSeparator.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropdownMenuSeparator>.NativeClassPtr, 100665729);
		}

		// Token: 0x0600111F RID: 4383 RVA: 0x00059198 File Offset: 0x00057398
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DropdownMenuSeparator(string subMenuPath)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DropdownMenuSeparator>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(subMenuPath);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DropdownMenuSeparator.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001120 RID: 4384 RVA: 0x00008977 File Offset: 0x00006B77
		public DropdownMenuSeparator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06001121 RID: 4385 RVA: 0x000591E4 File Offset: 0x000573E4
		// (set) Token: 0x06001122 RID: 4386 RVA: 0x00008980 File Offset: 0x00006B80
		public unsafe string _subMenuPath_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DropdownMenuSeparator.NativeFieldInfoPtr__subMenuPath_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DropdownMenuSeparator.NativeFieldInfoPtr__subMenuPath_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06001123 RID: 4387 RVA: 0x0000899F File Offset: 0x00006B9F
		public string subMenuPath
		{
			get
			{
				return this._subMenuPath_k__BackingField;
			}
		}

		// Token: 0x04000BCD RID: 3021
		private static readonly IntPtr NativeFieldInfoPtr__subMenuPath_k__BackingField;

		// Token: 0x04000BCE RID: 3022
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
