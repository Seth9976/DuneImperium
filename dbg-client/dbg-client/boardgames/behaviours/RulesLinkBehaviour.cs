using System;
using boardgames.menus.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using zen.src.audio;

namespace boardgames.behaviours
{
	// Token: 0x020002AC RID: 684
	public class RulesLinkBehaviour : MonoBehaviour
	{
		// Token: 0x0600206E RID: 8302 RVA: 0x00089A68 File Offset: 0x00087C68
		// Note: this type is marked as 'beforefieldinit'.
		static RulesLinkBehaviour()
		{
			Il2CppClassPointerStore<RulesLinkBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.behaviours", "RulesLinkBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RulesLinkBehaviour>.NativeClassPtr);
			RulesLinkBehaviour.NativeFieldInfoPtr_scrollToTargets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RulesLinkBehaviour>.NativeClassPtr, "scrollToTargets");
			RulesLinkBehaviour.NativeFieldInfoPtr_promptBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RulesLinkBehaviour>.NativeClassPtr, "promptBehaviour");
			RulesLinkBehaviour.NativeFieldInfoPtr_clickSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RulesLinkBehaviour>.NativeClassPtr, "clickSounds");
			RulesLinkBehaviour.NativeFieldInfoPtr_scrollRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RulesLinkBehaviour>.NativeClassPtr, "scrollRect");
			RulesLinkBehaviour.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RulesLinkBehaviour>.NativeClassPtr, 100668692);
			RulesLinkBehaviour.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RulesLinkBehaviour>.NativeClassPtr, 100668693);
			RulesLinkBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RulesLinkBehaviour>.NativeClassPtr, 100668694);
		}

		// Token: 0x0600206F RID: 8303 RVA: 0x00089B24 File Offset: 0x00087D24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542454, XrefRangeEnd = 542466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RulesLinkBehaviour.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002070 RID: 8304 RVA: 0x00089B58 File Offset: 0x00087D58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542466, XrefRangeEnd = 542504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerClick(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RulesLinkBehaviour.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002071 RID: 8305 RVA: 0x00089B9C File Offset: 0x00087D9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542504, XrefRangeEnd = 542512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RulesLinkBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RulesLinkBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RulesLinkBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002072 RID: 8306 RVA: 0x00010FDE File Offset: 0x0000F1DE
		public RulesLinkBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x06002073 RID: 8307 RVA: 0x00089BD8 File Offset: 0x00087DD8
		// (set) Token: 0x06002074 RID: 8308 RVA: 0x00010FE7 File Offset: 0x0000F1E7
		public unsafe Il2CppReferenceArray<RulesLinkBehaviour.LinkAndHeader> scrollToTargets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RulesLinkBehaviour.NativeFieldInfoPtr_scrollToTargets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RulesLinkBehaviour.LinkAndHeader>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RulesLinkBehaviour.NativeFieldInfoPtr_scrollToTargets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008A7 RID: 2215
		// (get) Token: 0x06002075 RID: 8309 RVA: 0x00089C08 File Offset: 0x00087E08
		// (set) Token: 0x06002076 RID: 8310 RVA: 0x00011006 File Offset: 0x0000F206
		public unsafe RulesPromptBehaviour promptBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RulesLinkBehaviour.NativeFieldInfoPtr_promptBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RulesPromptBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RulesLinkBehaviour.NativeFieldInfoPtr_promptBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x06002077 RID: 8311 RVA: 0x00089C38 File Offset: 0x00087E38
		// (set) Token: 0x06002078 RID: 8312 RVA: 0x00011025 File Offset: 0x0000F225
		public unsafe ZenClickEventPlaySound clickSounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RulesLinkBehaviour.NativeFieldInfoPtr_clickSounds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ZenClickEventPlaySound>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RulesLinkBehaviour.NativeFieldInfoPtr_clickSounds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008A9 RID: 2217
		// (get) Token: 0x06002079 RID: 8313 RVA: 0x00089C68 File Offset: 0x00087E68
		// (set) Token: 0x0600207A RID: 8314 RVA: 0x00011044 File Offset: 0x0000F244
		public unsafe ScrollRect scrollRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RulesLinkBehaviour.NativeFieldInfoPtr_scrollRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollRect>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RulesLinkBehaviour.NativeFieldInfoPtr_scrollRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400147C RID: 5244
		private static readonly IntPtr NativeFieldInfoPtr_scrollToTargets;

		// Token: 0x0400147D RID: 5245
		private static readonly IntPtr NativeFieldInfoPtr_promptBehaviour;

		// Token: 0x0400147E RID: 5246
		private static readonly IntPtr NativeFieldInfoPtr_clickSounds;

		// Token: 0x0400147F RID: 5247
		private static readonly IntPtr NativeFieldInfoPtr_scrollRect;

		// Token: 0x04001480 RID: 5248
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04001481 RID: 5249
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x04001482 RID: 5250
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020004A3 RID: 1187
		[Serializable]
		public sealed class LinkAndHeader : ValueType
		{
			// Token: 0x06003853 RID: 14419 RVA: 0x000D0B98 File Offset: 0x000CED98
			// Note: this type is marked as 'beforefieldinit'.
			static LinkAndHeader()
			{
				Il2CppClassPointerStore<RulesLinkBehaviour.LinkAndHeader>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RulesLinkBehaviour>.NativeClassPtr, "LinkAndHeader");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RulesLinkBehaviour.LinkAndHeader>.NativeClassPtr);
				RulesLinkBehaviour.LinkAndHeader.NativeFieldInfoPtr_Link = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RulesLinkBehaviour.LinkAndHeader>.NativeClassPtr, "Link");
				RulesLinkBehaviour.LinkAndHeader.NativeFieldInfoPtr_Header = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RulesLinkBehaviour.LinkAndHeader>.NativeClassPtr, "Header");
			}

			// Token: 0x06003854 RID: 14420 RVA: 0x0001CF8A File Offset: 0x0001B18A
			public LinkAndHeader(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003855 RID: 14421 RVA: 0x0001CF93 File Offset: 0x0001B193
			public LinkAndHeader()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RulesLinkBehaviour.LinkAndHeader>.NativeClassPtr))
			{
			}

			// Token: 0x170010A6 RID: 4262
			// (get) Token: 0x06003856 RID: 14422 RVA: 0x000D0BEC File Offset: 0x000CEDEC
			// (set) Token: 0x06003857 RID: 14423 RVA: 0x0001CFA5 File Offset: 0x0001B1A5
			public unsafe string Link
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RulesLinkBehaviour.LinkAndHeader.NativeFieldInfoPtr_Link);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RulesLinkBehaviour.LinkAndHeader.NativeFieldInfoPtr_Link), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170010A7 RID: 4263
			// (get) Token: 0x06003858 RID: 14424 RVA: 0x000D0C14 File Offset: 0x000CEE14
			// (set) Token: 0x06003859 RID: 14425 RVA: 0x0001CFC4 File Offset: 0x0001B1C4
			public unsafe RectTransform Header
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RulesLinkBehaviour.LinkAndHeader.NativeFieldInfoPtr_Header);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RulesLinkBehaviour.LinkAndHeader.NativeFieldInfoPtr_Header), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040022A0 RID: 8864
			private static readonly IntPtr NativeFieldInfoPtr_Link;

			// Token: 0x040022A1 RID: 8865
			private static readonly IntPtr NativeFieldInfoPtr_Header;
		}

		// Token: 0x020004A4 RID: 1188
		[ObfuscatedName("boardgames.behaviours.RulesLinkBehaviour+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600385A RID: 14426 RVA: 0x000D0C44 File Offset: 0x000CEE44
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<RulesLinkBehaviour.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RulesLinkBehaviour>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RulesLinkBehaviour.__c__DisplayClass6_0>.NativeClassPtr);
				RulesLinkBehaviour.__c__DisplayClass6_0.NativeFieldInfoPtr_linkInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RulesLinkBehaviour.__c__DisplayClass6_0>.NativeClassPtr, "linkInfo");
				RulesLinkBehaviour.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RulesLinkBehaviour.__c__DisplayClass6_0>.NativeClassPtr, 100668695);
				RulesLinkBehaviour.__c__DisplayClass6_0.NativeMethodInfoPtr__OnPointerClick_b__0_Internal_Boolean_LinkAndHeader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RulesLinkBehaviour.__c__DisplayClass6_0>.NativeClassPtr, 100668696);
			}

			// Token: 0x0600385B RID: 14427 RVA: 0x000D0CAC File Offset: 0x000CEEAC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RulesLinkBehaviour.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RulesLinkBehaviour.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600385C RID: 14428 RVA: 0x000D0CE8 File Offset: 0x000CEEE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542424, XrefRangeEnd = 542454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPointerClick_b__0(RulesLinkBehaviour.LinkAndHeader x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RulesLinkBehaviour.__c__DisplayClass6_0.NativeMethodInfoPtr__OnPointerClick_b__0_Internal_Boolean_LinkAndHeader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600385D RID: 14429 RVA: 0x0001CFE3 File Offset: 0x0001B1E3
			public __c__DisplayClass6_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170010A8 RID: 4264
			// (get) Token: 0x0600385E RID: 14430 RVA: 0x000D0D3C File Offset: 0x000CEF3C
			// (set) Token: 0x0600385F RID: 14431 RVA: 0x0001CFEC File Offset: 0x0001B1EC
			public TMP_LinkInfo linkInfo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RulesLinkBehaviour.__c__DisplayClass6_0.NativeFieldInfoPtr_linkInfo);
					return new TMP_LinkInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_LinkInfo>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RulesLinkBehaviour.__c__DisplayClass6_0.NativeFieldInfoPtr_linkInfo), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_LinkInfo>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040022A2 RID: 8866
			private static readonly IntPtr NativeFieldInfoPtr_linkInfo;

			// Token: 0x040022A3 RID: 8867
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040022A4 RID: 8868
			private static readonly IntPtr NativeMethodInfoPtr__OnPointerClick_b__0_Internal_Boolean_LinkAndHeader_0;
		}
	}
}
