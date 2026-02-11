using System;
using dwd.core.ui.prompt.behaviours;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine;

namespace worm.match.prompts.behaviours
{
	// Token: 0x020000D2 RID: 210
	public class WormEventLeaderboardPromptBehaviour : PromptBehaviour<IPromptWithData>
	{
		// Token: 0x060008E3 RID: 2275 RVA: 0x000336AC File Offset: 0x000318AC
		// Note: this type is marked as 'beforefieldinit'.
		static WormEventLeaderboardPromptBehaviour()
		{
			Il2CppClassPointerStore<WormEventLeaderboardPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.prompts.behaviours", "WormEventLeaderboardPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventLeaderboardPromptBehaviour>.NativeClassPtr);
			WormEventLeaderboardPromptBehaviour.NativeFieldInfoPtr_title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventLeaderboardPromptBehaviour>.NativeClassPtr, "title");
			WormEventLeaderboardPromptBehaviour.NativeFieldInfoPtr_entriesRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventLeaderboardPromptBehaviour>.NativeClassPtr, "entriesRoot");
			WormEventLeaderboardPromptBehaviour.NativeFieldInfoPtr_entryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventLeaderboardPromptBehaviour>.NativeClassPtr, "entryPrefab");
			WormEventLeaderboardPromptBehaviour.NativeFieldInfoPtr_currentPlayerDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventLeaderboardPromptBehaviour>.NativeClassPtr, "currentPlayerDisplay");
			WormEventLeaderboardPromptBehaviour.NativeFieldInfoPtr_currentPlayerEntryRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventLeaderboardPromptBehaviour>.NativeClassPtr, "currentPlayerEntryRoot");
			WormEventLeaderboardPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventLeaderboardPromptBehaviour>.NativeClassPtr, 100664513);
			WormEventLeaderboardPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventLeaderboardPromptBehaviour>.NativeClassPtr, 100664514);
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x00033768 File Offset: 0x00031968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 699056, XrefRangeEnd = 699150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormEventLeaderboardPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x000337A4 File Offset: 0x000319A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 699150, XrefRangeEnd = 699153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormEventLeaderboardPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventLeaderboardPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventLeaderboardPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x000068DB File Offset: 0x00004ADB
		public WormEventLeaderboardPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x060008E7 RID: 2279 RVA: 0x000337E0 File Offset: 0x000319E0
		// (set) Token: 0x060008E8 RID: 2280 RVA: 0x000068E4 File Offset: 0x00004AE4
		public unsafe TMP_Text title
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventLeaderboardPromptBehaviour.NativeFieldInfoPtr_title);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventLeaderboardPromptBehaviour.NativeFieldInfoPtr_title), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x060008E9 RID: 2281 RVA: 0x00033810 File Offset: 0x00031A10
		// (set) Token: 0x060008EA RID: 2282 RVA: 0x00006903 File Offset: 0x00004B03
		public unsafe Transform entriesRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventLeaderboardPromptBehaviour.NativeFieldInfoPtr_entriesRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventLeaderboardPromptBehaviour.NativeFieldInfoPtr_entriesRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x060008EB RID: 2283 RVA: 0x00033840 File Offset: 0x00031A40
		// (set) Token: 0x060008EC RID: 2284 RVA: 0x00006922 File Offset: 0x00004B22
		public unsafe SubscriptionProvider entryPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventLeaderboardPromptBehaviour.NativeFieldInfoPtr_entryPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubscriptionProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventLeaderboardPromptBehaviour.NativeFieldInfoPtr_entryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x060008ED RID: 2285 RVA: 0x00033870 File Offset: 0x00031A70
		// (set) Token: 0x060008EE RID: 2286 RVA: 0x00006941 File Offset: 0x00004B41
		public unsafe GameObject currentPlayerDisplay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventLeaderboardPromptBehaviour.NativeFieldInfoPtr_currentPlayerDisplay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventLeaderboardPromptBehaviour.NativeFieldInfoPtr_currentPlayerDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x060008EF RID: 2287 RVA: 0x000338A0 File Offset: 0x00031AA0
		// (set) Token: 0x060008F0 RID: 2288 RVA: 0x00006960 File Offset: 0x00004B60
		public unsafe Transform currentPlayerEntryRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventLeaderboardPromptBehaviour.NativeFieldInfoPtr_currentPlayerEntryRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventLeaderboardPromptBehaviour.NativeFieldInfoPtr_currentPlayerEntryRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400051F RID: 1311
		private static readonly IntPtr NativeFieldInfoPtr_title;

		// Token: 0x04000520 RID: 1312
		private static readonly IntPtr NativeFieldInfoPtr_entriesRoot;

		// Token: 0x04000521 RID: 1313
		private static readonly IntPtr NativeFieldInfoPtr_entryPrefab;

		// Token: 0x04000522 RID: 1314
		private static readonly IntPtr NativeFieldInfoPtr_currentPlayerDisplay;

		// Token: 0x04000523 RID: 1315
		private static readonly IntPtr NativeFieldInfoPtr_currentPlayerEntryRoot;

		// Token: 0x04000524 RID: 1316
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x04000525 RID: 1317
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
