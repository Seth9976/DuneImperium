using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace DG.Tweening.Plugins.Options
{
	// Token: 0x02000038 RID: 56
	public sealed class StringOptions : ValueType
	{
		// Token: 0x06000375 RID: 885 RVA: 0x00016E20 File Offset: 0x00015020
		// Note: this type is marked as 'beforefieldinit'.
		static StringOptions()
		{
			Il2CppClassPointerStore<StringOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Plugins.Options", "StringOptions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringOptions>.NativeClassPtr);
			StringOptions.NativeFieldInfoPtr_richTextEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringOptions>.NativeClassPtr, "richTextEnabled");
			StringOptions.NativeFieldInfoPtr_scrambleMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringOptions>.NativeClassPtr, "scrambleMode");
			StringOptions.NativeFieldInfoPtr_scrambledChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringOptions>.NativeClassPtr, "scrambledChars");
			StringOptions.NativeFieldInfoPtr_startValueStrippedLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringOptions>.NativeClassPtr, "startValueStrippedLength");
			StringOptions.NativeFieldInfoPtr_changeValueStrippedLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringOptions>.NativeClassPtr, "changeValueStrippedLength");
			StringOptions.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringOptions>.NativeClassPtr, 100664092);
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00016EC8 File Offset: 0x000150C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1132490, XrefRangeEnd = 1132491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringOptions.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000377 RID: 887 RVA: 0x00002FFD File Offset: 0x000011FD
		public StringOptions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000378 RID: 888 RVA: 0x00003006 File Offset: 0x00001206
		public StringOptions()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringOptions>.NativeClassPtr))
		{
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000379 RID: 889 RVA: 0x00016F00 File Offset: 0x00015100
		// (set) Token: 0x0600037A RID: 890 RVA: 0x00003018 File Offset: 0x00001218
		public unsafe bool richTextEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringOptions.NativeFieldInfoPtr_richTextEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringOptions.NativeFieldInfoPtr_richTextEnabled)) = value;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600037B RID: 891 RVA: 0x00016F28 File Offset: 0x00015128
		// (set) Token: 0x0600037C RID: 892 RVA: 0x00003033 File Offset: 0x00001233
		public unsafe ScrambleMode scrambleMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringOptions.NativeFieldInfoPtr_scrambleMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringOptions.NativeFieldInfoPtr_scrambleMode)) = value;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600037D RID: 893 RVA: 0x00016F50 File Offset: 0x00015150
		// (set) Token: 0x0600037E RID: 894 RVA: 0x0000304E File Offset: 0x0000124E
		public unsafe Il2CppStructArray<char> scrambledChars
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringOptions.NativeFieldInfoPtr_scrambledChars);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringOptions.NativeFieldInfoPtr_scrambledChars), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600037F RID: 895 RVA: 0x00016F80 File Offset: 0x00015180
		// (set) Token: 0x06000380 RID: 896 RVA: 0x0000306D File Offset: 0x0000126D
		public unsafe int startValueStrippedLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringOptions.NativeFieldInfoPtr_startValueStrippedLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringOptions.NativeFieldInfoPtr_startValueStrippedLength)) = value;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000381 RID: 897 RVA: 0x00016FA8 File Offset: 0x000151A8
		// (set) Token: 0x06000382 RID: 898 RVA: 0x00003088 File Offset: 0x00001288
		public unsafe int changeValueStrippedLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringOptions.NativeFieldInfoPtr_changeValueStrippedLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringOptions.NativeFieldInfoPtr_changeValueStrippedLength)) = value;
			}
		}

		// Token: 0x040002FF RID: 767
		private static readonly IntPtr NativeFieldInfoPtr_richTextEnabled;

		// Token: 0x04000300 RID: 768
		private static readonly IntPtr NativeFieldInfoPtr_scrambleMode;

		// Token: 0x04000301 RID: 769
		private static readonly IntPtr NativeFieldInfoPtr_scrambledChars;

		// Token: 0x04000302 RID: 770
		private static readonly IntPtr NativeFieldInfoPtr_startValueStrippedLength;

		// Token: 0x04000303 RID: 771
		private static readonly IntPtr NativeFieldInfoPtr_changeValueStrippedLength;

		// Token: 0x04000304 RID: 772
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;
	}
}
