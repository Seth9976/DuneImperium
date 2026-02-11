using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace dwd.core.cheats
{
	// Token: 0x020000A6 RID: 166
	public class SuggestCheatsForInput : MonoBehaviour
	{
		// Token: 0x060007F1 RID: 2033 RVA: 0x0002A0F4 File Offset: 0x000282F4
		// Note: this type is marked as 'beforefieldinit'.
		static SuggestCheatsForInput()
		{
			Il2CppClassPointerStore<SuggestCheatsForInput>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "dwd.core.cheats", "SuggestCheatsForInput");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SuggestCheatsForInput>.NativeClassPtr);
			SuggestCheatsForInput.NativeFieldInfoPtr_suggestionPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SuggestCheatsForInput>.NativeClassPtr, "suggestionPrefab");
			SuggestCheatsForInput.NativeFieldInfoPtr_suggestionsRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SuggestCheatsForInput>.NativeClassPtr, "suggestionsRoot");
			SuggestCheatsForInput.NativeFieldInfoPtr_cheats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SuggestCheatsForInput>.NativeClassPtr, "cheats");
			SuggestCheatsForInput.NativeMethodInfoPtr_Event_UpdateSuggestions_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SuggestCheatsForInput>.NativeClassPtr, 100664545);
			SuggestCheatsForInput.NativeMethodInfoPtr_Event_ClearSuggestions_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SuggestCheatsForInput>.NativeClassPtr, 100664546);
			SuggestCheatsForInput.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SuggestCheatsForInput>.NativeClassPtr, 100664547);
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x0002A19C File Offset: 0x0002839C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_UpdateSuggestions(string inputText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(inputText);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SuggestCheatsForInput.NativeMethodInfoPtr_Event_UpdateSuggestions_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x0002A1E0 File Offset: 0x000283E0
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ClearSuggestions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SuggestCheatsForInput.NativeMethodInfoPtr_Event_ClearSuggestions_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x0002A214 File Offset: 0x00028414
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SuggestCheatsForInput()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SuggestCheatsForInput>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SuggestCheatsForInput.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x000059A1 File Offset: 0x00003BA1
		public SuggestCheatsForInput(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x060007F6 RID: 2038 RVA: 0x0002A250 File Offset: 0x00028450
		// (set) Token: 0x060007F7 RID: 2039 RVA: 0x000059AA File Offset: 0x00003BAA
		public unsafe GameObject suggestionPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SuggestCheatsForInput.NativeFieldInfoPtr_suggestionPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SuggestCheatsForInput.NativeFieldInfoPtr_suggestionPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x060007F8 RID: 2040 RVA: 0x0002A280 File Offset: 0x00028480
		// (set) Token: 0x060007F9 RID: 2041 RVA: 0x000059C9 File Offset: 0x00003BC9
		public unsafe Transform suggestionsRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SuggestCheatsForInput.NativeFieldInfoPtr_suggestionsRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SuggestCheatsForInput.NativeFieldInfoPtr_suggestionsRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x060007FA RID: 2042 RVA: 0x0002A2B0 File Offset: 0x000284B0
		// (set) Token: 0x060007FB RID: 2043 RVA: 0x000059E8 File Offset: 0x00003BE8
		public unsafe Cheats cheats
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SuggestCheatsForInput.NativeFieldInfoPtr_cheats);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cheats>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SuggestCheatsForInput.NativeFieldInfoPtr_cheats), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004D6 RID: 1238
		private static readonly IntPtr NativeFieldInfoPtr_suggestionPrefab;

		// Token: 0x040004D7 RID: 1239
		private static readonly IntPtr NativeFieldInfoPtr_suggestionsRoot;

		// Token: 0x040004D8 RID: 1240
		private static readonly IntPtr NativeFieldInfoPtr_cheats;

		// Token: 0x040004D9 RID: 1241
		private static readonly IntPtr NativeMethodInfoPtr_Event_UpdateSuggestions_Public_Void_String_0;

		// Token: 0x040004DA RID: 1242
		private static readonly IntPtr NativeMethodInfoPtr_Event_ClearSuggestions_Public_Void_0;

		// Token: 0x040004DB RID: 1243
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
