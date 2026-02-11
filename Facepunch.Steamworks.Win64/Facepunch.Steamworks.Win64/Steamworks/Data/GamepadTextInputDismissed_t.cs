using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000108 RID: 264
	[StructLayout(2)]
	public struct GamepadTextInputDismissed_t
	{
		// Token: 0x06000FB4 RID: 4020 RVA: 0x0005DEA4 File Offset: 0x0005C0A4
		// Note: this type is marked as 'beforefieldinit'.
		static GamepadTextInputDismissed_t()
		{
			Il2CppClassPointerStore<GamepadTextInputDismissed_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "GamepadTextInputDismissed_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GamepadTextInputDismissed_t>.NativeClassPtr);
			GamepadTextInputDismissed_t.NativeFieldInfoPtr_Submitted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTextInputDismissed_t>.NativeClassPtr, "Submitted");
			GamepadTextInputDismissed_t.NativeFieldInfoPtr_SubmittedText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTextInputDismissed_t>.NativeClassPtr, "SubmittedText");
			GamepadTextInputDismissed_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadTextInputDismissed_t>.NativeClassPtr, "_datasize");
			GamepadTextInputDismissed_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTextInputDismissed_t>.NativeClassPtr, 100666852);
			GamepadTextInputDismissed_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadTextInputDismissed_t>.NativeClassPtr, 100666853);
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000FB5 RID: 4021 RVA: 0x0005DF38 File Offset: 0x0005C138
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950299, XrefRangeEnd = 950303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadTextInputDismissed_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06000FB6 RID: 4022 RVA: 0x0005DF68 File Offset: 0x0005C168
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadTextInputDismissed_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FB7 RID: 4023 RVA: 0x00004556 File Offset: 0x00002756
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GamepadTextInputDismissed_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000FB8 RID: 4024 RVA: 0x0005DF98 File Offset: 0x0005C198
		// (set) Token: 0x06000FB9 RID: 4025 RVA: 0x00004568 File Offset: 0x00002768
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GamepadTextInputDismissed_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GamepadTextInputDismissed_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040015DF RID: 5599
		private static readonly IntPtr NativeFieldInfoPtr_Submitted;

		// Token: 0x040015E0 RID: 5600
		private static readonly IntPtr NativeFieldInfoPtr_SubmittedText;

		// Token: 0x040015E1 RID: 5601
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040015E2 RID: 5602
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040015E3 RID: 5603
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x040015E4 RID: 5604
		[FieldOffset(0)]
		[MarshalAs(4)]
		public bool Submitted;

		// Token: 0x040015E5 RID: 5605
		[FieldOffset(4)]
		public uint SubmittedText;
	}
}
