using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace boardgames
{
	// Token: 0x02000101 RID: 257
	public class AnimParamDependencies : MonoBehaviour
	{
		// Token: 0x06000C52 RID: 3154 RVA: 0x000384D0 File Offset: 0x000366D0
		// Note: this type is marked as 'beforefieldinit'.
		static AnimParamDependencies()
		{
			Il2CppClassPointerStore<AnimParamDependencies>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames", "AnimParamDependencies");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimParamDependencies>.NativeClassPtr);
			AnimParamDependencies.NativeFieldInfoPtr_animatorDependencies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimParamDependencies>.NativeClassPtr, "animatorDependencies");
			AnimParamDependencies.NativeFieldInfoPtr__anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimParamDependencies>.NativeClassPtr, "_anim");
			AnimParamDependencies.NativeFieldInfoPtr_waitingForDisable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimParamDependencies>.NativeClassPtr, "waitingForDisable");
			AnimParamDependencies.NativeMethodInfoPtr_get_anim_Private_get_Animator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimParamDependencies>.NativeClassPtr, 100665259);
			AnimParamDependencies.NativeMethodInfoPtr_AnimDependsOn_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimParamDependencies>.NativeClassPtr, 100665260);
			AnimParamDependencies.NativeMethodInfoPtr_AnyDependenciesEnabled_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimParamDependencies>.NativeClassPtr, 100665261);
			AnimParamDependencies.NativeMethodInfoPtr_HandleDependencies_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimParamDependencies>.NativeClassPtr, 100665262);
			AnimParamDependencies.NativeMethodInfoPtr_SetBoolHandleDependencies_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimParamDependencies>.NativeClassPtr, 100665263);
			AnimParamDependencies.NativeMethodInfoPtr_Event_DisableReady_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimParamDependencies>.NativeClassPtr, 100665264);
			AnimParamDependencies.NativeMethodInfoPtr_delayDisable_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimParamDependencies>.NativeClassPtr, 100665265);
			AnimParamDependencies.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimParamDependencies>.NativeClassPtr, 100665266);
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06000C53 RID: 3155 RVA: 0x000385DC File Offset: 0x000367DC
		public unsafe Animator anim
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 995569, RefRangeEnd = 995577, XrefRangeStart = 995560, XrefRangeEnd = 995569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimParamDependencies.NativeMethodInfoPtr_get_anim_Private_get_Animator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr3) : null;
			}
		}

		// Token: 0x06000C54 RID: 3156 RVA: 0x0003861C File Offset: 0x0003681C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995577, XrefRangeEnd = 995581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AnimDependsOn(string param)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(param);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimParamDependencies.NativeMethodInfoPtr_AnimDependsOn_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C55 RID: 3157 RVA: 0x0003866C File Offset: 0x0003686C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 995600, RefRangeEnd = 995602, XrefRangeStart = 995581, XrefRangeEnd = 995600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AnyDependenciesEnabled(string ignoreParam = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ignoreParam);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimParamDependencies.NativeMethodInfoPtr_AnyDependenciesEnabled_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C56 RID: 3158 RVA: 0x000386BC File Offset: 0x000368BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 995610, RefRangeEnd = 995611, XrefRangeStart = 995602, XrefRangeEnd = 995610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleDependencies()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimParamDependencies.NativeMethodInfoPtr_HandleDependencies_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C57 RID: 3159 RVA: 0x000386F0 File Offset: 0x000368F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 995627, RefRangeEnd = 995628, XrefRangeStart = 995611, XrefRangeEnd = 995627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBoolHandleDependencies(string paramToSet, bool newParamValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(paramToSet);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newParamValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimParamDependencies.NativeMethodInfoPtr_SetBoolHandleDependencies_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C58 RID: 3160 RVA: 0x00038740 File Offset: 0x00036940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995628, XrefRangeEnd = 995634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_DisableReady()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimParamDependencies.NativeMethodInfoPtr_Event_DisableReady_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C59 RID: 3161 RVA: 0x00038774 File Offset: 0x00036974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995634, XrefRangeEnd = 995639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator delayDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimParamDependencies.NativeMethodInfoPtr_delayDisable_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000C5A RID: 3162 RVA: 0x000387B4 File Offset: 0x000369B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995639, XrefRangeEnd = 995647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimParamDependencies()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimParamDependencies>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimParamDependencies.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C5B RID: 3163 RVA: 0x00007AAA File Offset: 0x00005CAA
		public AnimParamDependencies(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06000C5C RID: 3164 RVA: 0x000387F0 File Offset: 0x000369F0
		// (set) Token: 0x06000C5D RID: 3165 RVA: 0x00007AB3 File Offset: 0x00005CB3
		public unsafe List<string> animatorDependencies
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimParamDependencies.NativeFieldInfoPtr_animatorDependencies);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimParamDependencies.NativeFieldInfoPtr_animatorDependencies), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06000C5E RID: 3166 RVA: 0x00038820 File Offset: 0x00036A20
		// (set) Token: 0x06000C5F RID: 3167 RVA: 0x00007AD2 File Offset: 0x00005CD2
		public unsafe Animator _anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimParamDependencies.NativeFieldInfoPtr__anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimParamDependencies.NativeFieldInfoPtr__anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06000C60 RID: 3168 RVA: 0x00038850 File Offset: 0x00036A50
		// (set) Token: 0x06000C61 RID: 3169 RVA: 0x00007AF1 File Offset: 0x00005CF1
		public unsafe bool waitingForDisable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimParamDependencies.NativeFieldInfoPtr_waitingForDisable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimParamDependencies.NativeFieldInfoPtr_waitingForDisable)) = value;
			}
		}

		// Token: 0x04000797 RID: 1943
		private static readonly IntPtr NativeFieldInfoPtr_animatorDependencies;

		// Token: 0x04000798 RID: 1944
		private static readonly IntPtr NativeFieldInfoPtr__anim;

		// Token: 0x04000799 RID: 1945
		private static readonly IntPtr NativeFieldInfoPtr_waitingForDisable;

		// Token: 0x0400079A RID: 1946
		private static readonly IntPtr NativeMethodInfoPtr_get_anim_Private_get_Animator_0;

		// Token: 0x0400079B RID: 1947
		private static readonly IntPtr NativeMethodInfoPtr_AnimDependsOn_Public_Boolean_String_0;

		// Token: 0x0400079C RID: 1948
		private static readonly IntPtr NativeMethodInfoPtr_AnyDependenciesEnabled_Public_Boolean_String_0;

		// Token: 0x0400079D RID: 1949
		private static readonly IntPtr NativeMethodInfoPtr_HandleDependencies_Public_Void_0;

		// Token: 0x0400079E RID: 1950
		private static readonly IntPtr NativeMethodInfoPtr_SetBoolHandleDependencies_Public_Void_String_Boolean_0;

		// Token: 0x0400079F RID: 1951
		private static readonly IntPtr NativeMethodInfoPtr_Event_DisableReady_Public_Void_0;

		// Token: 0x040007A0 RID: 1952
		private static readonly IntPtr NativeMethodInfoPtr_delayDisable_Private_IEnumerator_0;

		// Token: 0x040007A1 RID: 1953
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200024E RID: 590
		[ObfuscatedName("boardgames.AnimParamDependencies+<delayDisable>d__10")]
		public sealed class _delayDisable_d__10 : global::Il2CppSystem.Object
		{
			// Token: 0x06001B5F RID: 7007 RVA: 0x000659E4 File Offset: 0x00063BE4
			// Note: this type is marked as 'beforefieldinit'.
			static _delayDisable_d__10()
			{
				Il2CppClassPointerStore<AnimParamDependencies._delayDisable_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AnimParamDependencies>.NativeClassPtr, "<delayDisable>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimParamDependencies._delayDisable_d__10>.NativeClassPtr);
				AnimParamDependencies._delayDisable_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimParamDependencies._delayDisable_d__10>.NativeClassPtr, "<>1__state");
				AnimParamDependencies._delayDisable_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimParamDependencies._delayDisable_d__10>.NativeClassPtr, "<>2__current");
				AnimParamDependencies._delayDisable_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimParamDependencies._delayDisable_d__10>.NativeClassPtr, "<>4__this");
				AnimParamDependencies._delayDisable_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimParamDependencies._delayDisable_d__10>.NativeClassPtr, 100665267);
				AnimParamDependencies._delayDisable_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimParamDependencies._delayDisable_d__10>.NativeClassPtr, 100665268);
				AnimParamDependencies._delayDisable_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimParamDependencies._delayDisable_d__10>.NativeClassPtr, 100665269);
				AnimParamDependencies._delayDisable_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimParamDependencies._delayDisable_d__10>.NativeClassPtr, 100665270);
				AnimParamDependencies._delayDisable_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimParamDependencies._delayDisable_d__10>.NativeClassPtr, 100665271);
				AnimParamDependencies._delayDisable_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimParamDependencies._delayDisable_d__10>.NativeClassPtr, 100665272);
			}

			// Token: 0x06001B60 RID: 7008 RVA: 0x00065AC4 File Offset: 0x00063CC4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _delayDisable_d__10(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimParamDependencies._delayDisable_d__10>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimParamDependencies._delayDisable_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B61 RID: 7009 RVA: 0x00065B0C File Offset: 0x00063D0C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimParamDependencies._delayDisable_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B62 RID: 7010 RVA: 0x00065B40 File Offset: 0x00063D40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995553, XrefRangeEnd = 995555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimParamDependencies._delayDisable_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000813 RID: 2067
			// (get) Token: 0x06001B63 RID: 7011 RVA: 0x00065B7C File Offset: 0x00063D7C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimParamDependencies._delayDisable_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001B64 RID: 7012 RVA: 0x00065BBC File Offset: 0x00063DBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995555, XrefRangeEnd = 995560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimParamDependencies._delayDisable_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000814 RID: 2068
			// (get) Token: 0x06001B65 RID: 7013 RVA: 0x00065BF0 File Offset: 0x00063DF0
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimParamDependencies._delayDisable_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001B66 RID: 7014 RVA: 0x0000ED66 File Offset: 0x0000CF66
			public _delayDisable_d__10(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000810 RID: 2064
			// (get) Token: 0x06001B67 RID: 7015 RVA: 0x00065C30 File Offset: 0x00063E30
			// (set) Token: 0x06001B68 RID: 7016 RVA: 0x0000ED6F File Offset: 0x0000CF6F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimParamDependencies._delayDisable_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimParamDependencies._delayDisable_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000811 RID: 2065
			// (get) Token: 0x06001B69 RID: 7017 RVA: 0x00065C58 File Offset: 0x00063E58
			// (set) Token: 0x06001B6A RID: 7018 RVA: 0x0000ED8A File Offset: 0x0000CF8A
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimParamDependencies._delayDisable_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimParamDependencies._delayDisable_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000812 RID: 2066
			// (get) Token: 0x06001B6B RID: 7019 RVA: 0x00065C88 File Offset: 0x00063E88
			// (set) Token: 0x06001B6C RID: 7020 RVA: 0x0000EDA9 File Offset: 0x0000CFA9
			public unsafe AnimParamDependencies __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimParamDependencies._delayDisable_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimParamDependencies>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimParamDependencies._delayDisable_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400108E RID: 4238
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400108F RID: 4239
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001090 RID: 4240
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001091 RID: 4241
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001092 RID: 4242
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001093 RID: 4243
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001094 RID: 4244
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001095 RID: 4245
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001096 RID: 4246
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
