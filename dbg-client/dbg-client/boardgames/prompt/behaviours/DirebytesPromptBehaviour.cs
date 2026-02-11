using System;
using dwd.core.data.composition;
using dwd.core.prefabs.prefabProvider;
using dwd.core.ui.match.prompt.prompts;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace boardgames.prompt.behaviours
{
	// Token: 0x02000103 RID: 259
	public class DirebytesPromptBehaviour : PromptBehaviour<FlavoredDismissablePrompt>
	{
		// Token: 0x06000B21 RID: 2849 RVA: 0x00040C1C File Offset: 0x0003EE1C
		// Note: this type is marked as 'beforefieldinit'.
		static DirebytesPromptBehaviour()
		{
			Il2CppClassPointerStore<DirebytesPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.prompt.behaviours", "DirebytesPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DirebytesPromptBehaviour>.NativeClassPtr);
			DirebytesPromptBehaviour.NativeFieldInfoPtr_providerInstantiator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirebytesPromptBehaviour>.NativeClassPtr, "providerInstantiator");
			DirebytesPromptBehaviour.NativeFieldInfoPtr_noAlertText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirebytesPromptBehaviour>.NativeClassPtr, "noAlertText");
			DirebytesPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirebytesPromptBehaviour>.NativeClassPtr, 100664919);
			DirebytesPromptBehaviour.NativeMethodInfoPtr_Event_Dismiss_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirebytesPromptBehaviour>.NativeClassPtr, 100664920);
			DirebytesPromptBehaviour.NativeMethodInfoPtr_Event_SelectDirebyte_Public_Void_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirebytesPromptBehaviour>.NativeClassPtr, 100664921);
			DirebytesPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirebytesPromptBehaviour>.NativeClassPtr, 100664922);
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x00040CC4 File Offset: 0x0003EEC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507791, XrefRangeEnd = 507844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DirebytesPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x00040D00 File Offset: 0x0003EF00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507844, XrefRangeEnd = 507849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Dismiss()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirebytesPromptBehaviour.NativeMethodInfoPtr_Event_Dismiss_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B24 RID: 2852 RVA: 0x00040D34 File Offset: 0x0003EF34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507849, XrefRangeEnd = 507896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_SelectDirebyte(DataComposition data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirebytesPromptBehaviour.NativeMethodInfoPtr_Event_SelectDirebyte_Public_Void_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B25 RID: 2853 RVA: 0x00040D78 File Offset: 0x0003EF78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507896, XrefRangeEnd = 507899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DirebytesPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DirebytesPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirebytesPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B26 RID: 2854 RVA: 0x000074B9 File Offset: 0x000056B9
		public DirebytesPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000B27 RID: 2855 RVA: 0x00040DB4 File Offset: 0x0003EFB4
		// (set) Token: 0x06000B28 RID: 2856 RVA: 0x000074C2 File Offset: 0x000056C2
		public unsafe ProviderInstantiator providerInstantiator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirebytesPromptBehaviour.NativeFieldInfoPtr_providerInstantiator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProviderInstantiator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirebytesPromptBehaviour.NativeFieldInfoPtr_providerInstantiator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000B29 RID: 2857 RVA: 0x00040DE4 File Offset: 0x0003EFE4
		// (set) Token: 0x06000B2A RID: 2858 RVA: 0x000074E1 File Offset: 0x000056E1
		public unsafe GameObject noAlertText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirebytesPromptBehaviour.NativeFieldInfoPtr_noAlertText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirebytesPromptBehaviour.NativeFieldInfoPtr_noAlertText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006D7 RID: 1751
		private static readonly IntPtr NativeFieldInfoPtr_providerInstantiator;

		// Token: 0x040006D8 RID: 1752
		private static readonly IntPtr NativeFieldInfoPtr_noAlertText;

		// Token: 0x040006D9 RID: 1753
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x040006DA RID: 1754
		private static readonly IntPtr NativeMethodInfoPtr_Event_Dismiss_Public_Void_0;

		// Token: 0x040006DB RID: 1755
		private static readonly IntPtr NativeMethodInfoPtr_Event_SelectDirebyte_Public_Void_DataComposition_0;

		// Token: 0x040006DC RID: 1756
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
