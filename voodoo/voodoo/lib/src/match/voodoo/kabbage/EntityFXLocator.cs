using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace lib.src.match.voodoo.kabbage
{
	// Token: 0x0200000C RID: 12
	public class EntityFXLocator : MonoBehaviour
	{
		// Token: 0x06000049 RID: 73 RVA: 0x00009EC8 File Offset: 0x000080C8
		// Note: this type is marked as 'beforefieldinit'.
		static EntityFXLocator()
		{
			Il2CppClassPointerStore<EntityFXLocator>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lib.src.match.voodoo.kabbage", "EntityFXLocator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityFXLocator>.NativeClassPtr);
			EntityFXLocator.NativeFieldInfoPtr_kabbageAnchors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityFXLocator>.NativeClassPtr, "kabbageAnchors");
			EntityFXLocator.NativeFieldInfoPtr_fxAnimators = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityFXLocator>.NativeClassPtr, "fxAnimators");
			EntityFXLocator.NativeFieldInfoPtr_blockingAnimations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityFXLocator>.NativeClassPtr, "blockingAnimations");
			EntityFXLocator.NativeFieldInfoPtr_kabbageLocations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityFXLocator>.NativeClassPtr, "kabbageLocations");
			EntityFXLocator.NativeFieldInfoPtr_fxLocations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityFXLocator>.NativeClassPtr, "fxLocations");
			EntityFXLocator.NativeFieldInfoPtr_blockingFXLocations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityFXLocator>.NativeClassPtr, "blockingFXLocations");
			EntityFXLocator.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityFXLocator>.NativeClassPtr, 100663328);
			EntityFXLocator.NativeMethodInfoPtr_GetFXTransform_Public_Virtual_New_Transform_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityFXLocator>.NativeClassPtr, 100663329);
			EntityFXLocator.NativeMethodInfoPtr_TryPlayFX_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityFXLocator>.NativeClassPtr, 100663330);
			EntityFXLocator.NativeMethodInfoPtr_TryPlayBlockingFX_Public_Virtual_Final_New_IEnumerator_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityFXLocator>.NativeClassPtr, 100663331);
			EntityFXLocator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityFXLocator>.NativeClassPtr, 100663332);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00009FD4 File Offset: 0x000081D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106614, XrefRangeEnd = 1106626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityFXLocator.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x0000A008 File Offset: 0x00008208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106626, XrefRangeEnd = 1106629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Transform GetFXTransform(string fxName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fxName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityFXLocator.NativeMethodInfoPtr_GetFXTransform_Public_Virtual_New_Transform_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x0000A064 File Offset: 0x00008264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106629, XrefRangeEnd = 1106639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void TryPlayFX(string fxName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fxName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityFXLocator.NativeMethodInfoPtr_TryPlayFX_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x0000A0A8 File Offset: 0x000082A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106639, XrefRangeEnd = 1106645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator TryPlayBlockingFX(string fxName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fxName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityFXLocator.NativeMethodInfoPtr_TryPlayBlockingFX_Public_Virtual_Final_New_IEnumerator_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x0000A0F8 File Offset: 0x000082F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106645, XrefRangeEnd = 1106667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityFXLocator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityFXLocator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityFXLocator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x0000232A File Offset: 0x0000052A
		public EntityFXLocator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000050 RID: 80 RVA: 0x0000A134 File Offset: 0x00008334
		// (set) Token: 0x06000051 RID: 81 RVA: 0x00002333 File Offset: 0x00000533
		public unsafe Il2CppReferenceArray<KabbageAnchorInfo> kabbageAnchors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityFXLocator.NativeFieldInfoPtr_kabbageAnchors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KabbageAnchorInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityFXLocator.NativeFieldInfoPtr_kabbageAnchors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000052 RID: 82 RVA: 0x0000A164 File Offset: 0x00008364
		// (set) Token: 0x06000053 RID: 83 RVA: 0x00002352 File Offset: 0x00000552
		public unsafe Il2CppReferenceArray<FXAnimatorInfo> fxAnimators
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityFXLocator.NativeFieldInfoPtr_fxAnimators);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FXAnimatorInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityFXLocator.NativeFieldInfoPtr_fxAnimators), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000054 RID: 84 RVA: 0x0000A194 File Offset: 0x00008394
		// (set) Token: 0x06000055 RID: 85 RVA: 0x00002371 File Offset: 0x00000571
		public unsafe Il2CppReferenceArray<BlockingFXInfo> blockingAnimations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityFXLocator.NativeFieldInfoPtr_blockingAnimations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BlockingFXInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityFXLocator.NativeFieldInfoPtr_blockingAnimations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000056 RID: 86 RVA: 0x0000A1C4 File Offset: 0x000083C4
		// (set) Token: 0x06000057 RID: 87 RVA: 0x00002390 File Offset: 0x00000590
		public unsafe Dictionary<string, KabbageAnchorInfo> kabbageLocations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityFXLocator.NativeFieldInfoPtr_kabbageLocations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, KabbageAnchorInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityFXLocator.NativeFieldInfoPtr_kabbageLocations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000058 RID: 88 RVA: 0x0000A1F4 File Offset: 0x000083F4
		// (set) Token: 0x06000059 RID: 89 RVA: 0x000023AF File Offset: 0x000005AF
		public unsafe Dictionary<string, FXAnimatorInfo> fxLocations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityFXLocator.NativeFieldInfoPtr_fxLocations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, FXAnimatorInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityFXLocator.NativeFieldInfoPtr_fxLocations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600005A RID: 90 RVA: 0x0000A224 File Offset: 0x00008424
		// (set) Token: 0x0600005B RID: 91 RVA: 0x000023CE File Offset: 0x000005CE
		public unsafe Dictionary<string, BlockingFXInfo> blockingFXLocations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityFXLocator.NativeFieldInfoPtr_blockingFXLocations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, BlockingFXInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityFXLocator.NativeFieldInfoPtr_blockingFXLocations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeFieldInfoPtr_kabbageAnchors;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeFieldInfoPtr_fxAnimators;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeFieldInfoPtr_blockingAnimations;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeFieldInfoPtr_kabbageLocations;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeFieldInfoPtr_fxLocations;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeFieldInfoPtr_blockingFXLocations;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr_GetFXTransform_Public_Virtual_New_Transform_String_0;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeMethodInfoPtr_TryPlayFX_Public_Virtual_Final_New_Void_String_0;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeMethodInfoPtr_TryPlayBlockingFX_Public_Virtual_Final_New_IEnumerator_String_0;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000B2 RID: 178
		[ObfuscatedName("lib.src.match.voodoo.kabbage.EntityFXLocator+<TryPlayBlockingFX>d__9")]
		public sealed class _TryPlayBlockingFX_d__9 : global::Il2CppSystem.Object
		{
			// Token: 0x060009FA RID: 2554 RVA: 0x0002A7C0 File Offset: 0x000289C0
			// Note: this type is marked as 'beforefieldinit'.
			static _TryPlayBlockingFX_d__9()
			{
				Il2CppClassPointerStore<EntityFXLocator._TryPlayBlockingFX_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EntityFXLocator>.NativeClassPtr, "<TryPlayBlockingFX>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityFXLocator._TryPlayBlockingFX_d__9>.NativeClassPtr);
				EntityFXLocator._TryPlayBlockingFX_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityFXLocator._TryPlayBlockingFX_d__9>.NativeClassPtr, "<>1__state");
				EntityFXLocator._TryPlayBlockingFX_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityFXLocator._TryPlayBlockingFX_d__9>.NativeClassPtr, "<>2__current");
				EntityFXLocator._TryPlayBlockingFX_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityFXLocator._TryPlayBlockingFX_d__9>.NativeClassPtr, "<>4__this");
				EntityFXLocator._TryPlayBlockingFX_d__9.NativeFieldInfoPtr_fxName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityFXLocator._TryPlayBlockingFX_d__9>.NativeClassPtr, "fxName");
				EntityFXLocator._TryPlayBlockingFX_d__9.NativeFieldInfoPtr__run_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityFXLocator._TryPlayBlockingFX_d__9>.NativeClassPtr, "<run>5__2");
				EntityFXLocator._TryPlayBlockingFX_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityFXLocator._TryPlayBlockingFX_d__9>.NativeClassPtr, 100663333);
				EntityFXLocator._TryPlayBlockingFX_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityFXLocator._TryPlayBlockingFX_d__9>.NativeClassPtr, 100663334);
				EntityFXLocator._TryPlayBlockingFX_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityFXLocator._TryPlayBlockingFX_d__9>.NativeClassPtr, 100663335);
				EntityFXLocator._TryPlayBlockingFX_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityFXLocator._TryPlayBlockingFX_d__9>.NativeClassPtr, 100663336);
				EntityFXLocator._TryPlayBlockingFX_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityFXLocator._TryPlayBlockingFX_d__9>.NativeClassPtr, 100663337);
				EntityFXLocator._TryPlayBlockingFX_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityFXLocator._TryPlayBlockingFX_d__9>.NativeClassPtr, 100663338);
			}

			// Token: 0x060009FB RID: 2555 RVA: 0x0002A8C8 File Offset: 0x00028AC8
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _TryPlayBlockingFX_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityFXLocator._TryPlayBlockingFX_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityFXLocator._TryPlayBlockingFX_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060009FC RID: 2556 RVA: 0x0002A910 File Offset: 0x00028B10
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityFXLocator._TryPlayBlockingFX_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060009FD RID: 2557 RVA: 0x0002A944 File Offset: 0x00028B44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106593, XrefRangeEnd = 1106609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityFXLocator._TryPlayBlockingFX_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170002E4 RID: 740
			// (get) Token: 0x060009FE RID: 2558 RVA: 0x0002A980 File Offset: 0x00028B80
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityFXLocator._TryPlayBlockingFX_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060009FF RID: 2559 RVA: 0x0002A9C0 File Offset: 0x00028BC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106609, XrefRangeEnd = 1106614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityFXLocator._TryPlayBlockingFX_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170002E5 RID: 741
			// (get) Token: 0x06000A00 RID: 2560 RVA: 0x0002A9F4 File Offset: 0x00028BF4
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityFXLocator._TryPlayBlockingFX_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000A01 RID: 2561 RVA: 0x00006DC0 File Offset: 0x00004FC0
			public _TryPlayBlockingFX_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170002DF RID: 735
			// (get) Token: 0x06000A02 RID: 2562 RVA: 0x0002AA34 File Offset: 0x00028C34
			// (set) Token: 0x06000A03 RID: 2563 RVA: 0x00006DC9 File Offset: 0x00004FC9
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityFXLocator._TryPlayBlockingFX_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityFXLocator._TryPlayBlockingFX_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170002E0 RID: 736
			// (get) Token: 0x06000A04 RID: 2564 RVA: 0x0002AA5C File Offset: 0x00028C5C
			// (set) Token: 0x06000A05 RID: 2565 RVA: 0x00006DE4 File Offset: 0x00004FE4
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityFXLocator._TryPlayBlockingFX_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityFXLocator._TryPlayBlockingFX_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170002E1 RID: 737
			// (get) Token: 0x06000A06 RID: 2566 RVA: 0x0002AA8C File Offset: 0x00028C8C
			// (set) Token: 0x06000A07 RID: 2567 RVA: 0x00006E03 File Offset: 0x00005003
			public unsafe EntityFXLocator __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityFXLocator._TryPlayBlockingFX_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityFXLocator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityFXLocator._TryPlayBlockingFX_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170002E2 RID: 738
			// (get) Token: 0x06000A08 RID: 2568 RVA: 0x0002AABC File Offset: 0x00028CBC
			// (set) Token: 0x06000A09 RID: 2569 RVA: 0x00006E22 File Offset: 0x00005022
			public unsafe string fxName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityFXLocator._TryPlayBlockingFX_d__9.NativeFieldInfoPtr_fxName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityFXLocator._TryPlayBlockingFX_d__9.NativeFieldInfoPtr_fxName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170002E3 RID: 739
			// (get) Token: 0x06000A0A RID: 2570 RVA: 0x0002AAE4 File Offset: 0x00028CE4
			// (set) Token: 0x06000A0B RID: 2571 RVA: 0x00006E41 File Offset: 0x00005041
			public unsafe IEnumerator _run_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityFXLocator._TryPlayBlockingFX_d__9.NativeFieldInfoPtr__run_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityFXLocator._TryPlayBlockingFX_d__9.NativeFieldInfoPtr__run_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000632 RID: 1586
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000633 RID: 1587
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000634 RID: 1588
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000635 RID: 1589
			private static readonly IntPtr NativeFieldInfoPtr_fxName;

			// Token: 0x04000636 RID: 1590
			private static readonly IntPtr NativeFieldInfoPtr__run_5__2;

			// Token: 0x04000637 RID: 1591
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000638 RID: 1592
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000639 RID: 1593
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400063A RID: 1594
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400063B RID: 1595
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400063C RID: 1596
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
