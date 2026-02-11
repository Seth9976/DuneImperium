using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace boardgames.menus.behaviours
{
	// Token: 0x020001BF RID: 447
	public class TutorialFocusManager : MonoBehaviour
	{
		// Token: 0x06001420 RID: 5152 RVA: 0x0005E900 File Offset: 0x0005CB00
		// Note: this type is marked as 'beforefieldinit'.
		static TutorialFocusManager()
		{
			Il2CppClassPointerStore<TutorialFocusManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.behaviours", "TutorialFocusManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialFocusManager>.NativeClassPtr);
			TutorialFocusManager.NativeFieldInfoPtr_MAX_ALPHA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialFocusManager>.NativeClassPtr, "MAX_ALPHA");
			TutorialFocusManager.NativeFieldInfoPtr_fadeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialFocusManager>.NativeClassPtr, "fadeTime");
			TutorialFocusManager.NativeFieldInfoPtr_Focuses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialFocusManager>.NativeClassPtr, "Focuses");
			TutorialFocusManager.NativeFieldInfoPtr_previousFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialFocusManager>.NativeClassPtr, "previousFocus");
			TutorialFocusManager.NativeFieldInfoPtr_currentFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialFocusManager>.NativeClassPtr, "currentFocus");
			TutorialFocusManager.NativeMethodInfoPtr_fade_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialFocusManager>.NativeClassPtr, 100666243);
			TutorialFocusManager.NativeMethodInfoPtr_Focus_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialFocusManager>.NativeClassPtr, 100666244);
			TutorialFocusManager.NativeMethodInfoPtr_Unfocus_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialFocusManager>.NativeClassPtr, 100666245);
			TutorialFocusManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialFocusManager>.NativeClassPtr, 100666246);
		}

		// Token: 0x06001421 RID: 5153 RVA: 0x0005E9E4 File Offset: 0x0005CBE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 520102, RefRangeEnd = 520103, XrefRangeStart = 520097, XrefRangeEnd = 520102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator fade()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialFocusManager.NativeMethodInfoPtr_fade_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001422 RID: 5154 RVA: 0x0005EA24 File Offset: 0x0005CC24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 520109, RefRangeEnd = 520110, XrefRangeStart = 520103, XrefRangeEnd = 520109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Focus(string identifier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialFocusManager.NativeMethodInfoPtr_Focus_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001423 RID: 5155 RVA: 0x0005EA68 File Offset: 0x0005CC68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 520110, XrefRangeEnd = 520118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Unfocus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialFocusManager.NativeMethodInfoPtr_Unfocus_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001424 RID: 5156 RVA: 0x0005EA9C File Offset: 0x0005CC9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 520118, XrefRangeEnd = 520123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TutorialFocusManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialFocusManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialFocusManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001425 RID: 5157 RVA: 0x0000B78F File Offset: 0x0000998F
		public TutorialFocusManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x06001426 RID: 5158 RVA: 0x0005EAD8 File Offset: 0x0005CCD8
		// (set) Token: 0x06001427 RID: 5159 RVA: 0x0000B798 File Offset: 0x00009998
		public unsafe float MAX_ALPHA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialFocusManager.NativeFieldInfoPtr_MAX_ALPHA);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialFocusManager.NativeFieldInfoPtr_MAX_ALPHA)) = value;
			}
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x06001428 RID: 5160 RVA: 0x0005EB00 File Offset: 0x0005CD00
		// (set) Token: 0x06001429 RID: 5161 RVA: 0x0000B7B3 File Offset: 0x000099B3
		public unsafe float fadeTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialFocusManager.NativeFieldInfoPtr_fadeTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialFocusManager.NativeFieldInfoPtr_fadeTime)) = value;
			}
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x0600142A RID: 5162 RVA: 0x0005EB28 File Offset: 0x0005CD28
		// (set) Token: 0x0600142B RID: 5163 RVA: 0x0000B7CE File Offset: 0x000099CE
		public unsafe Il2CppReferenceArray<TutorialFocusManager.TutorialFocus> Focuses
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialFocusManager.NativeFieldInfoPtr_Focuses);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TutorialFocusManager.TutorialFocus>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialFocusManager.NativeFieldInfoPtr_Focuses), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x0600142C RID: 5164 RVA: 0x0005EB58 File Offset: 0x0005CD58
		// (set) Token: 0x0600142D RID: 5165 RVA: 0x0000B7ED File Offset: 0x000099ED
		public unsafe TutorialFocusManager.TutorialFocus previousFocus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialFocusManager.NativeFieldInfoPtr_previousFocus);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TutorialFocusManager.TutorialFocus>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialFocusManager.NativeFieldInfoPtr_previousFocus), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x0600142E RID: 5166 RVA: 0x0005EB88 File Offset: 0x0005CD88
		// (set) Token: 0x0600142F RID: 5167 RVA: 0x0000B80C File Offset: 0x00009A0C
		public unsafe TutorialFocusManager.TutorialFocus currentFocus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialFocusManager.NativeFieldInfoPtr_currentFocus);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TutorialFocusManager.TutorialFocus>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialFocusManager.NativeFieldInfoPtr_currentFocus), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C67 RID: 3175
		private static readonly IntPtr NativeFieldInfoPtr_MAX_ALPHA;

		// Token: 0x04000C68 RID: 3176
		private static readonly IntPtr NativeFieldInfoPtr_fadeTime;

		// Token: 0x04000C69 RID: 3177
		private static readonly IntPtr NativeFieldInfoPtr_Focuses;

		// Token: 0x04000C6A RID: 3178
		private static readonly IntPtr NativeFieldInfoPtr_previousFocus;

		// Token: 0x04000C6B RID: 3179
		private static readonly IntPtr NativeFieldInfoPtr_currentFocus;

		// Token: 0x04000C6C RID: 3180
		private static readonly IntPtr NativeMethodInfoPtr_fade_Private_IEnumerator_0;

		// Token: 0x04000C6D RID: 3181
		private static readonly IntPtr NativeMethodInfoPtr_Focus_Public_Void_String_0;

		// Token: 0x04000C6E RID: 3182
		private static readonly IntPtr NativeMethodInfoPtr_Unfocus_Public_Void_0;

		// Token: 0x04000C6F RID: 3183
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003AC RID: 940
		[Serializable]
		public class TutorialFocus : global::Il2CppSystem.Object
		{
			// Token: 0x06002C03 RID: 11267 RVA: 0x000AC1DC File Offset: 0x000AA3DC
			// Note: this type is marked as 'beforefieldinit'.
			static TutorialFocus()
			{
				Il2CppClassPointerStore<TutorialFocusManager.TutorialFocus>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialFocusManager>.NativeClassPtr, "TutorialFocus");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialFocusManager.TutorialFocus>.NativeClassPtr);
				TutorialFocusManager.TutorialFocus.NativeFieldInfoPtr_identifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialFocusManager.TutorialFocus>.NativeClassPtr, "identifier");
				TutorialFocusManager.TutorialFocus.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialFocusManager.TutorialFocus>.NativeClassPtr, "canvas");
				TutorialFocusManager.TutorialFocus.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialFocusManager.TutorialFocus>.NativeClassPtr, 100666247);
			}

			// Token: 0x06002C04 RID: 11268 RVA: 0x000AC244 File Offset: 0x000AA444
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 520070, XrefRangeEnd = 520075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TutorialFocus()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialFocusManager.TutorialFocus>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialFocusManager.TutorialFocus.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C05 RID: 11269 RVA: 0x00016C3C File Offset: 0x00014E3C
			public TutorialFocus(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C7B RID: 3195
			// (get) Token: 0x06002C06 RID: 11270 RVA: 0x000AC280 File Offset: 0x000AA480
			// (set) Token: 0x06002C07 RID: 11271 RVA: 0x00016C45 File Offset: 0x00014E45
			public unsafe string identifier
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialFocusManager.TutorialFocus.NativeFieldInfoPtr_identifier);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialFocusManager.TutorialFocus.NativeFieldInfoPtr_identifier), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000C7C RID: 3196
			// (get) Token: 0x06002C08 RID: 11272 RVA: 0x000AC2A8 File Offset: 0x000AA4A8
			// (set) Token: 0x06002C09 RID: 11273 RVA: 0x00016C64 File Offset: 0x00014E64
			public unsafe CanvasGroup canvas
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialFocusManager.TutorialFocus.NativeFieldInfoPtr_canvas);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialFocusManager.TutorialFocus.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001B64 RID: 7012
			private static readonly IntPtr NativeFieldInfoPtr_identifier;

			// Token: 0x04001B65 RID: 7013
			private static readonly IntPtr NativeFieldInfoPtr_canvas;

			// Token: 0x04001B66 RID: 7014
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020003AD RID: 941
		[ObfuscatedName("boardgames.menus.behaviours.TutorialFocusManager+<fade>d__6")]
		public sealed class _fade_d__6 : global::Il2CppSystem.Object
		{
			// Token: 0x06002C0A RID: 11274 RVA: 0x000AC2D8 File Offset: 0x000AA4D8
			// Note: this type is marked as 'beforefieldinit'.
			static _fade_d__6()
			{
				Il2CppClassPointerStore<TutorialFocusManager._fade_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialFocusManager>.NativeClassPtr, "<fade>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialFocusManager._fade_d__6>.NativeClassPtr);
				TutorialFocusManager._fade_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialFocusManager._fade_d__6>.NativeClassPtr, "<>1__state");
				TutorialFocusManager._fade_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialFocusManager._fade_d__6>.NativeClassPtr, "<>2__current");
				TutorialFocusManager._fade_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialFocusManager._fade_d__6>.NativeClassPtr, "<>4__this");
				TutorialFocusManager._fade_d__6.NativeFieldInfoPtr__prev_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialFocusManager._fade_d__6>.NativeClassPtr, "<prev>5__2");
				TutorialFocusManager._fade_d__6.NativeFieldInfoPtr__current_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialFocusManager._fade_d__6>.NativeClassPtr, "<current>5__3");
				TutorialFocusManager._fade_d__6.NativeFieldInfoPtr__startTime_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialFocusManager._fade_d__6>.NativeClassPtr, "<startTime>5__4");
				TutorialFocusManager._fade_d__6.NativeFieldInfoPtr__elapsed_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialFocusManager._fade_d__6>.NativeClassPtr, "<elapsed>5__5");
				TutorialFocusManager._fade_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialFocusManager._fade_d__6>.NativeClassPtr, 100666248);
				TutorialFocusManager._fade_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialFocusManager._fade_d__6>.NativeClassPtr, 100666249);
				TutorialFocusManager._fade_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialFocusManager._fade_d__6>.NativeClassPtr, 100666250);
				TutorialFocusManager._fade_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialFocusManager._fade_d__6>.NativeClassPtr, 100666251);
				TutorialFocusManager._fade_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialFocusManager._fade_d__6>.NativeClassPtr, 100666252);
				TutorialFocusManager._fade_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialFocusManager._fade_d__6>.NativeClassPtr, 100666253);
			}

			// Token: 0x06002C0B RID: 11275 RVA: 0x000AC408 File Offset: 0x000AA608
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _fade_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialFocusManager._fade_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialFocusManager._fade_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002C0C RID: 11276 RVA: 0x000AC450 File Offset: 0x000AA650
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialFocusManager._fade_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C0D RID: 11277 RVA: 0x000AC484 File Offset: 0x000AA684
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 520075, XrefRangeEnd = 520092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialFocusManager._fade_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000C84 RID: 3204
			// (get) Token: 0x06002C0E RID: 11278 RVA: 0x000AC4C0 File Offset: 0x000AA6C0
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialFocusManager._fade_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002C0F RID: 11279 RVA: 0x000AC500 File Offset: 0x000AA700
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 520092, XrefRangeEnd = 520097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialFocusManager._fade_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000C85 RID: 3205
			// (get) Token: 0x06002C10 RID: 11280 RVA: 0x000AC534 File Offset: 0x000AA734
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialFocusManager._fade_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002C11 RID: 11281 RVA: 0x00016C83 File Offset: 0x00014E83
			public _fade_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C7D RID: 3197
			// (get) Token: 0x06002C12 RID: 11282 RVA: 0x000AC574 File Offset: 0x000AA774
			// (set) Token: 0x06002C13 RID: 11283 RVA: 0x00016C8C File Offset: 0x00014E8C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialFocusManager._fade_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialFocusManager._fade_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000C7E RID: 3198
			// (get) Token: 0x06002C14 RID: 11284 RVA: 0x000AC59C File Offset: 0x000AA79C
			// (set) Token: 0x06002C15 RID: 11285 RVA: 0x00016CA7 File Offset: 0x00014EA7
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialFocusManager._fade_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialFocusManager._fade_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C7F RID: 3199
			// (get) Token: 0x06002C16 RID: 11286 RVA: 0x000AC5CC File Offset: 0x000AA7CC
			// (set) Token: 0x06002C17 RID: 11287 RVA: 0x00016CC6 File Offset: 0x00014EC6
			public unsafe TutorialFocusManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialFocusManager._fade_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TutorialFocusManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialFocusManager._fade_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C80 RID: 3200
			// (get) Token: 0x06002C18 RID: 11288 RVA: 0x000AC5FC File Offset: 0x000AA7FC
			// (set) Token: 0x06002C19 RID: 11289 RVA: 0x00016CE5 File Offset: 0x00014EE5
			public unsafe TutorialFocusManager.TutorialFocus _prev_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialFocusManager._fade_d__6.NativeFieldInfoPtr__prev_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TutorialFocusManager.TutorialFocus>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialFocusManager._fade_d__6.NativeFieldInfoPtr__prev_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C81 RID: 3201
			// (get) Token: 0x06002C1A RID: 11290 RVA: 0x000AC62C File Offset: 0x000AA82C
			// (set) Token: 0x06002C1B RID: 11291 RVA: 0x00016D04 File Offset: 0x00014F04
			public unsafe TutorialFocusManager.TutorialFocus _current_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialFocusManager._fade_d__6.NativeFieldInfoPtr__current_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TutorialFocusManager.TutorialFocus>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialFocusManager._fade_d__6.NativeFieldInfoPtr__current_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C82 RID: 3202
			// (get) Token: 0x06002C1C RID: 11292 RVA: 0x000AC65C File Offset: 0x000AA85C
			// (set) Token: 0x06002C1D RID: 11293 RVA: 0x00016D23 File Offset: 0x00014F23
			public unsafe float _startTime_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialFocusManager._fade_d__6.NativeFieldInfoPtr__startTime_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialFocusManager._fade_d__6.NativeFieldInfoPtr__startTime_5__4)) = value;
				}
			}

			// Token: 0x17000C83 RID: 3203
			// (get) Token: 0x06002C1E RID: 11294 RVA: 0x000AC684 File Offset: 0x000AA884
			// (set) Token: 0x06002C1F RID: 11295 RVA: 0x00016D3E File Offset: 0x00014F3E
			public unsafe float _elapsed_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialFocusManager._fade_d__6.NativeFieldInfoPtr__elapsed_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialFocusManager._fade_d__6.NativeFieldInfoPtr__elapsed_5__5)) = value;
				}
			}

			// Token: 0x04001B67 RID: 7015
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001B68 RID: 7016
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001B69 RID: 7017
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001B6A RID: 7018
			private static readonly IntPtr NativeFieldInfoPtr__prev_5__2;

			// Token: 0x04001B6B RID: 7019
			private static readonly IntPtr NativeFieldInfoPtr__current_5__3;

			// Token: 0x04001B6C RID: 7020
			private static readonly IntPtr NativeFieldInfoPtr__startTime_5__4;

			// Token: 0x04001B6D RID: 7021
			private static readonly IntPtr NativeFieldInfoPtr__elapsed_5__5;

			// Token: 0x04001B6E RID: 7022
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001B6F RID: 7023
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001B70 RID: 7024
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001B71 RID: 7025
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001B72 RID: 7026
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001B73 RID: 7027
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
