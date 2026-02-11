using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace dwd.core.util
{
	// Token: 0x0200008A RID: 138
	public class DuplicateLogFileOnQuit : MonoBehaviour
	{
		// Token: 0x06000A09 RID: 2569 RVA: 0x00039EB4 File Offset: 0x000380B4
		// Note: this type is marked as 'beforefieldinit'.
		static DuplicateLogFileOnQuit()
		{
			Il2CppClassPointerStore<DuplicateLogFileOnQuit>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.util", "DuplicateLogFileOnQuit");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DuplicateLogFileOnQuit>.NativeClassPtr);
			DuplicateLogFileOnQuit.NativeFieldInfoPtr_handled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuplicateLogFileOnQuit>.NativeClassPtr, "handled");
			DuplicateLogFileOnQuit.NativeMethodInfoPtr_HandleApplicationQuit_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuplicateLogFileOnQuit>.NativeClassPtr, 100664693);
			DuplicateLogFileOnQuit.NativeMethodInfoPtr_dupeFile_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuplicateLogFileOnQuit>.NativeClassPtr, 100664694);
			DuplicateLogFileOnQuit.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuplicateLogFileOnQuit>.NativeClassPtr, 100664695);
		}

		// Token: 0x06000A0A RID: 2570 RVA: 0x00039F34 File Offset: 0x00038134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862529, XrefRangeEnd = 862546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void HandleApplicationQuit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DuplicateLogFileOnQuit.NativeMethodInfoPtr_HandleApplicationQuit_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A0B RID: 2571 RVA: 0x00039F68 File Offset: 0x00038168
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 862560, RefRangeEnd = 862562, XrefRangeStart = 862546, XrefRangeEnd = 862560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void dupeFile(string oldPath, string newPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(oldPath);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(newPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DuplicateLogFileOnQuit.NativeMethodInfoPtr_dupeFile_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A0C RID: 2572 RVA: 0x00039FBC File Offset: 0x000381BC
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DuplicateLogFileOnQuit()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DuplicateLogFileOnQuit>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DuplicateLogFileOnQuit.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A0D RID: 2573 RVA: 0x0000586F File Offset: 0x00003A6F
		public DuplicateLogFileOnQuit(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06000A0E RID: 2574 RVA: 0x00039FF8 File Offset: 0x000381F8
		// (set) Token: 0x06000A0F RID: 2575 RVA: 0x00005878 File Offset: 0x00003A78
		public unsafe bool handled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DuplicateLogFileOnQuit.NativeFieldInfoPtr_handled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DuplicateLogFileOnQuit.NativeFieldInfoPtr_handled)) = value;
			}
		}

		// Token: 0x04000766 RID: 1894
		private static readonly IntPtr NativeFieldInfoPtr_handled;

		// Token: 0x04000767 RID: 1895
		private static readonly IntPtr NativeMethodInfoPtr_HandleApplicationQuit_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000768 RID: 1896
		private static readonly IntPtr NativeMethodInfoPtr_dupeFile_Private_Void_String_String_0;

		// Token: 0x04000769 RID: 1897
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
