using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace TMPro
{
	// Token: 0x02000053 RID: 83
	public class TMP_SpriteAnimator : MonoBehaviour
	{
		// Token: 0x06000968 RID: 2408 RVA: 0x000284E8 File Offset: 0x000266E8
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_SpriteAnimator()
		{
			Il2CppClassPointerStore<TMP_SpriteAnimator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_SpriteAnimator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_SpriteAnimator>.NativeClassPtr);
			TMP_SpriteAnimator.NativeFieldInfoPtr_m_animations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAnimator>.NativeClassPtr, "m_animations");
			TMP_SpriteAnimator.NativeFieldInfoPtr_m_TextComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAnimator>.NativeClassPtr, "m_TextComponent");
			TMP_SpriteAnimator.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAnimator>.NativeClassPtr, 100664326);
			TMP_SpriteAnimator.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAnimator>.NativeClassPtr, 100664327);
			TMP_SpriteAnimator.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAnimator>.NativeClassPtr, 100664328);
			TMP_SpriteAnimator.NativeMethodInfoPtr_StopAllAnimations_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAnimator>.NativeClassPtr, 100664329);
			TMP_SpriteAnimator.NativeMethodInfoPtr_DoSpriteAnimation_Public_Void_Int32_TMP_SpriteAsset_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAnimator>.NativeClassPtr, 100664330);
			TMP_SpriteAnimator.NativeMethodInfoPtr_DoSpriteAnimationInternal_Private_IEnumerator_Int32_TMP_SpriteAsset_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAnimator>.NativeClassPtr, 100664331);
			TMP_SpriteAnimator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAnimator>.NativeClassPtr, 100664332);
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x000285CC File Offset: 0x000267CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1045876, XrefRangeEnd = 1045880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAnimator.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x00028600 File Offset: 0x00026800
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAnimator.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x00028634 File Offset: 0x00026834
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAnimator.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x00028668 File Offset: 0x00026868
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1045885, RefRangeEnd = 1045887, XrefRangeStart = 1045880, XrefRangeEnd = 1045885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopAllAnimations()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAnimator.NativeMethodInfoPtr_StopAllAnimations_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x0002869C File Offset: 0x0002689C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1045887, XrefRangeEnd = 1045900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoSpriteAnimation(int currentCharacter, TMP_SpriteAsset spriteAsset, int start, int end, int framerate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref currentCharacter;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(spriteAsset);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref framerate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAnimator.NativeMethodInfoPtr_DoSpriteAnimation_Public_Void_Int32_TMP_SpriteAsset_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x00028718 File Offset: 0x00026918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1045900, XrefRangeEnd = 1045906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DoSpriteAnimationInternal(int currentCharacter, TMP_SpriteAsset spriteAsset, int start, int end, int framerate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref currentCharacter;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(spriteAsset);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref framerate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAnimator.NativeMethodInfoPtr_DoSpriteAnimationInternal_Private_IEnumerator_Int32_TMP_SpriteAsset_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x000287A0 File Offset: 0x000269A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1045906, XrefRangeEnd = 1045914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_SpriteAnimator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_SpriteAnimator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAnimator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x00006601 File Offset: 0x00004801
		public TMP_SpriteAnimator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06000971 RID: 2417 RVA: 0x000287DC File Offset: 0x000269DC
		// (set) Token: 0x06000972 RID: 2418 RVA: 0x0000660A File Offset: 0x0000480A
		public unsafe Dictionary<int, bool> m_animations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator.NativeFieldInfoPtr_m_animations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator.NativeFieldInfoPtr_m_animations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06000973 RID: 2419 RVA: 0x0002880C File Offset: 0x00026A0C
		// (set) Token: 0x06000974 RID: 2420 RVA: 0x00006629 File Offset: 0x00004829
		public unsafe TMP_Text m_TextComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator.NativeFieldInfoPtr_m_TextComponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator.NativeFieldInfoPtr_m_TextComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000769 RID: 1897
		private static readonly IntPtr NativeFieldInfoPtr_m_animations;

		// Token: 0x0400076A RID: 1898
		private static readonly IntPtr NativeFieldInfoPtr_m_TextComponent;

		// Token: 0x0400076B RID: 1899
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400076C RID: 1900
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x0400076D RID: 1901
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x0400076E RID: 1902
		private static readonly IntPtr NativeMethodInfoPtr_StopAllAnimations_Public_Void_0;

		// Token: 0x0400076F RID: 1903
		private static readonly IntPtr NativeMethodInfoPtr_DoSpriteAnimation_Public_Void_Int32_TMP_SpriteAsset_Int32_Int32_Int32_0;

		// Token: 0x04000770 RID: 1904
		private static readonly IntPtr NativeMethodInfoPtr_DoSpriteAnimationInternal_Private_IEnumerator_Int32_TMP_SpriteAsset_Int32_Int32_Int32_0;

		// Token: 0x04000771 RID: 1905
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000A7 RID: 167
		[ObfuscatedName("TMPro.TMP_SpriteAnimator+<DoSpriteAnimationInternal>d__7")]
		public sealed class _DoSpriteAnimationInternal_d__7 : global::Il2CppSystem.Object
		{
			// Token: 0x06000FCE RID: 4046 RVA: 0x0003E78C File Offset: 0x0003C98C
			// Note: this type is marked as 'beforefieldinit'.
			static _DoSpriteAnimationInternal_d__7()
			{
				Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_SpriteAnimator>.NativeClassPtr, "<DoSpriteAnimationInternal>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr);
				TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr, "<>1__state");
				TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr, "<>2__current");
				TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr, "<>4__this");
				TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr, "start");
				TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr_end = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr, "end");
				TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr_spriteAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr, "spriteAsset");
				TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr_currentCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr, "currentCharacter");
				TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr_framerate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr, "framerate");
				TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__currentFrame_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr, "<currentFrame>5__2");
				TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__charInfo_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr, "<charInfo>5__3");
				TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__materialIndex_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr, "<materialIndex>5__4");
				TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__vertexIndex_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr, "<vertexIndex>5__5");
				TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__meshInfo_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr, "<meshInfo>5__6");
				TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__baseSpriteScale_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr, "<baseSpriteScale>5__7");
				TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__elapsedTime_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr, "<elapsedTime>5__8");
				TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__targetTime_5__9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr, "<targetTime>5__9");
				TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr, 100664333);
				TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr, 100664334);
				TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr, 100664335);
				TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr, 100664336);
				TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr, 100664337);
				TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr, 100664338);
			}

			// Token: 0x06000FCF RID: 4047 RVA: 0x0003E970 File Offset: 0x0003CB70
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DoSpriteAnimationInternal_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000FD0 RID: 4048 RVA: 0x0003E9B8 File Offset: 0x0003CBB8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000FD1 RID: 4049 RVA: 0x0003E9EC File Offset: 0x0003CBEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1045816, XrefRangeEnd = 1045871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170005CA RID: 1482
			// (get) Token: 0x06000FD2 RID: 4050 RVA: 0x0003EA28 File Offset: 0x0003CC28
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000FD3 RID: 4051 RVA: 0x0003EA68 File Offset: 0x0003CC68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1045871, XrefRangeEnd = 1045876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170005CB RID: 1483
			// (get) Token: 0x06000FD4 RID: 4052 RVA: 0x0003EA9C File Offset: 0x0003CC9C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000FD5 RID: 4053 RVA: 0x0000983F File Offset: 0x00007A3F
			public _DoSpriteAnimationInternal_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005BA RID: 1466
			// (get) Token: 0x06000FD6 RID: 4054 RVA: 0x0003EADC File Offset: 0x0003CCDC
			// (set) Token: 0x06000FD7 RID: 4055 RVA: 0x00009848 File Offset: 0x00007A48
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170005BB RID: 1467
			// (get) Token: 0x06000FD8 RID: 4056 RVA: 0x0003EB04 File Offset: 0x0003CD04
			// (set) Token: 0x06000FD9 RID: 4057 RVA: 0x00009863 File Offset: 0x00007A63
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005BC RID: 1468
			// (get) Token: 0x06000FDA RID: 4058 RVA: 0x0003EB34 File Offset: 0x0003CD34
			// (set) Token: 0x06000FDB RID: 4059 RVA: 0x00009882 File Offset: 0x00007A82
			public unsafe TMP_SpriteAnimator __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_SpriteAnimator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005BD RID: 1469
			// (get) Token: 0x06000FDC RID: 4060 RVA: 0x0003EB64 File Offset: 0x0003CD64
			// (set) Token: 0x06000FDD RID: 4061 RVA: 0x000098A1 File Offset: 0x00007AA1
			public unsafe int start
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr_start);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr_start)) = value;
				}
			}

			// Token: 0x170005BE RID: 1470
			// (get) Token: 0x06000FDE RID: 4062 RVA: 0x0003EB8C File Offset: 0x0003CD8C
			// (set) Token: 0x06000FDF RID: 4063 RVA: 0x000098BC File Offset: 0x00007ABC
			public unsafe int end
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr_end);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr_end)) = value;
				}
			}

			// Token: 0x170005BF RID: 1471
			// (get) Token: 0x06000FE0 RID: 4064 RVA: 0x0003EBB4 File Offset: 0x0003CDB4
			// (set) Token: 0x06000FE1 RID: 4065 RVA: 0x000098D7 File Offset: 0x00007AD7
			public unsafe TMP_SpriteAsset spriteAsset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr_spriteAsset);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_SpriteAsset>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr_spriteAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005C0 RID: 1472
			// (get) Token: 0x06000FE2 RID: 4066 RVA: 0x0003EBE4 File Offset: 0x0003CDE4
			// (set) Token: 0x06000FE3 RID: 4067 RVA: 0x000098F6 File Offset: 0x00007AF6
			public unsafe int currentCharacter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr_currentCharacter);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr_currentCharacter)) = value;
				}
			}

			// Token: 0x170005C1 RID: 1473
			// (get) Token: 0x06000FE4 RID: 4068 RVA: 0x0003EC0C File Offset: 0x0003CE0C
			// (set) Token: 0x06000FE5 RID: 4069 RVA: 0x00009911 File Offset: 0x00007B11
			public unsafe int framerate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr_framerate);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr_framerate)) = value;
				}
			}

			// Token: 0x170005C2 RID: 1474
			// (get) Token: 0x06000FE6 RID: 4070 RVA: 0x0003EC34 File Offset: 0x0003CE34
			// (set) Token: 0x06000FE7 RID: 4071 RVA: 0x0000992C File Offset: 0x00007B2C
			public unsafe int _currentFrame_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__currentFrame_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__currentFrame_5__2)) = value;
				}
			}

			// Token: 0x170005C3 RID: 1475
			// (get) Token: 0x06000FE8 RID: 4072 RVA: 0x0003EC5C File Offset: 0x0003CE5C
			// (set) Token: 0x06000FE9 RID: 4073 RVA: 0x00009947 File Offset: 0x00007B47
			public TMP_CharacterInfo _charInfo_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__charInfo_5__3);
					return new TMP_CharacterInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__charInfo_5__3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170005C4 RID: 1476
			// (get) Token: 0x06000FEA RID: 4074 RVA: 0x0003EC8C File Offset: 0x0003CE8C
			// (set) Token: 0x06000FEB RID: 4075 RVA: 0x00009975 File Offset: 0x00007B75
			public unsafe int _materialIndex_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__materialIndex_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__materialIndex_5__4)) = value;
				}
			}

			// Token: 0x170005C5 RID: 1477
			// (get) Token: 0x06000FEC RID: 4076 RVA: 0x0003ECB4 File Offset: 0x0003CEB4
			// (set) Token: 0x06000FED RID: 4077 RVA: 0x00009990 File Offset: 0x00007B90
			public unsafe int _vertexIndex_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__vertexIndex_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__vertexIndex_5__5)) = value;
				}
			}

			// Token: 0x170005C6 RID: 1478
			// (get) Token: 0x06000FEE RID: 4078 RVA: 0x0003ECDC File Offset: 0x0003CEDC
			// (set) Token: 0x06000FEF RID: 4079 RVA: 0x000099AB File Offset: 0x00007BAB
			public TMP_MeshInfo _meshInfo_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__meshInfo_5__6);
					return new TMP_MeshInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__meshInfo_5__6), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170005C7 RID: 1479
			// (get) Token: 0x06000FF0 RID: 4080 RVA: 0x0003ED0C File Offset: 0x0003CF0C
			// (set) Token: 0x06000FF1 RID: 4081 RVA: 0x000099D9 File Offset: 0x00007BD9
			public unsafe float _baseSpriteScale_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__baseSpriteScale_5__7);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__baseSpriteScale_5__7)) = value;
				}
			}

			// Token: 0x170005C8 RID: 1480
			// (get) Token: 0x06000FF2 RID: 4082 RVA: 0x0003ED34 File Offset: 0x0003CF34
			// (set) Token: 0x06000FF3 RID: 4083 RVA: 0x000099F4 File Offset: 0x00007BF4
			public unsafe float _elapsedTime_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__elapsedTime_5__8);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__elapsedTime_5__8)) = value;
				}
			}

			// Token: 0x170005C9 RID: 1481
			// (get) Token: 0x06000FF4 RID: 4084 RVA: 0x0003ED5C File Offset: 0x0003CF5C
			// (set) Token: 0x06000FF5 RID: 4085 RVA: 0x00009A0F File Offset: 0x00007C0F
			public unsafe float _targetTime_5__9
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__targetTime_5__9);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAnimator._DoSpriteAnimationInternal_d__7.NativeFieldInfoPtr__targetTime_5__9)) = value;
				}
			}

			// Token: 0x04000C63 RID: 3171
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000C64 RID: 3172
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000C65 RID: 3173
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000C66 RID: 3174
			private static readonly IntPtr NativeFieldInfoPtr_start;

			// Token: 0x04000C67 RID: 3175
			private static readonly IntPtr NativeFieldInfoPtr_end;

			// Token: 0x04000C68 RID: 3176
			private static readonly IntPtr NativeFieldInfoPtr_spriteAsset;

			// Token: 0x04000C69 RID: 3177
			private static readonly IntPtr NativeFieldInfoPtr_currentCharacter;

			// Token: 0x04000C6A RID: 3178
			private static readonly IntPtr NativeFieldInfoPtr_framerate;

			// Token: 0x04000C6B RID: 3179
			private static readonly IntPtr NativeFieldInfoPtr__currentFrame_5__2;

			// Token: 0x04000C6C RID: 3180
			private static readonly IntPtr NativeFieldInfoPtr__charInfo_5__3;

			// Token: 0x04000C6D RID: 3181
			private static readonly IntPtr NativeFieldInfoPtr__materialIndex_5__4;

			// Token: 0x04000C6E RID: 3182
			private static readonly IntPtr NativeFieldInfoPtr__vertexIndex_5__5;

			// Token: 0x04000C6F RID: 3183
			private static readonly IntPtr NativeFieldInfoPtr__meshInfo_5__6;

			// Token: 0x04000C70 RID: 3184
			private static readonly IntPtr NativeFieldInfoPtr__baseSpriteScale_5__7;

			// Token: 0x04000C71 RID: 3185
			private static readonly IntPtr NativeFieldInfoPtr__elapsedTime_5__8;

			// Token: 0x04000C72 RID: 3186
			private static readonly IntPtr NativeFieldInfoPtr__targetTime_5__9;

			// Token: 0x04000C73 RID: 3187
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000C74 RID: 3188
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000C75 RID: 3189
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000C76 RID: 3190
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000C77 RID: 3191
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000C78 RID: 3192
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
