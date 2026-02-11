using System;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using TMPro;

namespace boardgames.menus.prompts.behaviours
{
	// Token: 0x02000209 RID: 521
	public class ReportPlayerPromptBehaviour : PromptBehaviour<ReportPlayerPrompt>
	{
		// Token: 0x060017FB RID: 6139 RVA: 0x0006B730 File Offset: 0x00069930
		// Note: this type is marked as 'beforefieldinit'.
		static ReportPlayerPromptBehaviour()
		{
			Il2CppClassPointerStore<ReportPlayerPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.prompts.behaviours", "ReportPlayerPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReportPlayerPromptBehaviour>.NativeClassPtr);
			ReportPlayerPromptBehaviour.NativeFieldInfoPtr_mainBodyText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportPlayerPromptBehaviour>.NativeClassPtr, "mainBodyText");
			ReportPlayerPromptBehaviour.NativeFieldInfoPtr_reasonDropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportPlayerPromptBehaviour>.NativeClassPtr, "reasonDropdown");
			ReportPlayerPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportPlayerPromptBehaviour>.NativeClassPtr, 100666790);
			ReportPlayerPromptBehaviour.NativeMethodInfoPtr_Event_Send_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportPlayerPromptBehaviour>.NativeClassPtr, 100666791);
			ReportPlayerPromptBehaviour.NativeMethodInfoPtr_Event_Cancel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportPlayerPromptBehaviour>.NativeClassPtr, 100666792);
			ReportPlayerPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportPlayerPromptBehaviour>.NativeClassPtr, 100666793);
		}

		// Token: 0x060017FC RID: 6140 RVA: 0x0006B7D8 File Offset: 0x000699D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525748, XrefRangeEnd = 525782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReportPlayerPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017FD RID: 6141 RVA: 0x0006B814 File Offset: 0x00069A14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525782, XrefRangeEnd = 525794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Send()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportPlayerPromptBehaviour.NativeMethodInfoPtr_Event_Send_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017FE RID: 6142 RVA: 0x0006B848 File Offset: 0x00069A48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525794, XrefRangeEnd = 525803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Cancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportPlayerPromptBehaviour.NativeMethodInfoPtr_Event_Cancel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017FF RID: 6143 RVA: 0x0006B87C File Offset: 0x00069A7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525803, XrefRangeEnd = 525806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReportPlayerPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReportPlayerPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportPlayerPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001800 RID: 6144 RVA: 0x0000D51A File Offset: 0x0000B71A
		public ReportPlayerPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x06001801 RID: 6145 RVA: 0x0006B8B8 File Offset: 0x00069AB8
		// (set) Token: 0x06001802 RID: 6146 RVA: 0x0000D523 File Offset: 0x0000B723
		public unsafe TMP_InputField mainBodyText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportPlayerPromptBehaviour.NativeFieldInfoPtr_mainBodyText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportPlayerPromptBehaviour.NativeFieldInfoPtr_mainBodyText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x06001803 RID: 6147 RVA: 0x0006B8E8 File Offset: 0x00069AE8
		// (set) Token: 0x06001804 RID: 6148 RVA: 0x0000D542 File Offset: 0x0000B742
		public unsafe TMP_Dropdown reasonDropdown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportPlayerPromptBehaviour.NativeFieldInfoPtr_reasonDropdown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Dropdown>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportPlayerPromptBehaviour.NativeFieldInfoPtr_reasonDropdown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F07 RID: 3847
		private static readonly IntPtr NativeFieldInfoPtr_mainBodyText;

		// Token: 0x04000F08 RID: 3848
		private static readonly IntPtr NativeFieldInfoPtr_reasonDropdown;

		// Token: 0x04000F09 RID: 3849
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x04000F0A RID: 3850
		private static readonly IntPtr NativeMethodInfoPtr_Event_Send_Public_Void_0;

		// Token: 0x04000F0B RID: 3851
		private static readonly IntPtr NativeMethodInfoPtr_Event_Cancel_Public_Void_0;

		// Token: 0x04000F0C RID: 3852
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003D7 RID: 983
		[ObfuscatedName("boardgames.menus.prompts.behaviours.ReportPlayerPromptBehaviour+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002DB6 RID: 11702 RVA: 0x000B0FF4 File Offset: 0x000AF1F4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ReportPlayerPromptBehaviour.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReportPlayerPromptBehaviour>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReportPlayerPromptBehaviour.__c>.NativeClassPtr);
				ReportPlayerPromptBehaviour.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportPlayerPromptBehaviour.__c>.NativeClassPtr, "<>9");
				ReportPlayerPromptBehaviour.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportPlayerPromptBehaviour.__c>.NativeClassPtr, "<>9__2_0");
				ReportPlayerPromptBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportPlayerPromptBehaviour.__c>.NativeClassPtr, 100666795);
				ReportPlayerPromptBehaviour.__c.NativeMethodInfoPtr__initialize_b__2_0_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportPlayerPromptBehaviour.__c>.NativeClassPtr, 100666796);
			}

			// Token: 0x06002DB7 RID: 11703 RVA: 0x000B1070 File Offset: 0x000AF270
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReportPlayerPromptBehaviour.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportPlayerPromptBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002DB8 RID: 11704 RVA: 0x000B10AC File Offset: 0x000AF2AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525741, XrefRangeEnd = 525748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _initialize_b__2_0(string reason)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(reason);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportPlayerPromptBehaviour.__c.NativeMethodInfoPtr__initialize_b__2_0_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06002DB9 RID: 11705 RVA: 0x00017A28 File Offset: 0x00015C28
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000CFC RID: 3324
			// (get) Token: 0x06002DBA RID: 11706 RVA: 0x000B10F4 File Offset: 0x000AF2F4
			// (set) Token: 0x06002DBB RID: 11707 RVA: 0x00017A31 File Offset: 0x00015C31
			public unsafe static ReportPlayerPromptBehaviour.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ReportPlayerPromptBehaviour.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReportPlayerPromptBehaviour.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReportPlayerPromptBehaviour.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CFD RID: 3325
			// (get) Token: 0x06002DBC RID: 11708 RVA: 0x000B111C File Offset: 0x000AF31C
			// (set) Token: 0x06002DBD RID: 11709 RVA: 0x00017A43 File Offset: 0x00015C43
			public unsafe static Func<string, string> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ReportPlayerPromptBehaviour.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReportPlayerPromptBehaviour.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001C52 RID: 7250
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001C53 RID: 7251
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x04001C54 RID: 7252
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001C55 RID: 7253
			private static readonly IntPtr NativeMethodInfoPtr__initialize_b__2_0_Internal_String_String_0;
		}
	}
}
