using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using voodoo.kabbage;

namespace worm.client.match.render
{
	// Token: 0x0200029D RID: 669
	public class WormVoodooAttachToUnit : MonoBehaviour
	{
		// Token: 0x06001B34 RID: 6964 RVA: 0x0006B9CC File Offset: 0x00069BCC
		// Note: this type is marked as 'beforefieldinit'.
		static WormVoodooAttachToUnit()
		{
			Il2CppClassPointerStore<WormVoodooAttachToUnit>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.client.match.render", "WormVoodooAttachToUnit");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormVoodooAttachToUnit>.NativeClassPtr);
			WormVoodooAttachToUnit.NativeFieldInfoPtr_voodooAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormVoodooAttachToUnit>.NativeClassPtr, "voodooAnimator");
			WormVoodooAttachToUnit.NativeFieldInfoPtr_detachAfter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormVoodooAttachToUnit>.NativeClassPtr, "detachAfter");
			WormVoodooAttachToUnit.NativeFieldInfoPtr_targets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormVoodooAttachToUnit>.NativeClassPtr, "targets");
			WormVoodooAttachToUnit.NativeMethodInfoPtr_Event_AttachIndex_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVoodooAttachToUnit>.NativeClassPtr, 100667257);
			WormVoodooAttachToUnit.NativeMethodInfoPtr_DetachAfter_Private_Static_IEnumerator_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVoodooAttachToUnit>.NativeClassPtr, 100667258);
			WormVoodooAttachToUnit.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVoodooAttachToUnit>.NativeClassPtr, 100667259);
		}

		// Token: 0x06001B35 RID: 6965 RVA: 0x0006BA74 File Offset: 0x00069C74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724212, XrefRangeEnd = 724255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_AttachIndex(int targetIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref targetIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVoodooAttachToUnit.NativeMethodInfoPtr_Event_AttachIndex_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B36 RID: 6966 RVA: 0x0006BAB4 File Offset: 0x00069CB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724255, XrefRangeEnd = 724260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator DetachAfter(Transform target, float seconds)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seconds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVoodooAttachToUnit.NativeMethodInfoPtr_DetachAfter_Private_Static_IEnumerator_Transform_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001B37 RID: 6967 RVA: 0x0006BB08 File Offset: 0x00069D08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724260, XrefRangeEnd = 724265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormVoodooAttachToUnit()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormVoodooAttachToUnit>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVoodooAttachToUnit.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B38 RID: 6968 RVA: 0x0000FC2C File Offset: 0x0000DE2C
		public WormVoodooAttachToUnit(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x06001B39 RID: 6969 RVA: 0x0006BB44 File Offset: 0x00069D44
		// (set) Token: 0x06001B3A RID: 6970 RVA: 0x0000FC35 File Offset: 0x0000DE35
		public unsafe VoodooRenderAnimator voodooAnimator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVoodooAttachToUnit.NativeFieldInfoPtr_voodooAnimator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VoodooRenderAnimator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVoodooAttachToUnit.NativeFieldInfoPtr_voodooAnimator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x06001B3B RID: 6971 RVA: 0x0006BB74 File Offset: 0x00069D74
		// (set) Token: 0x06001B3C RID: 6972 RVA: 0x0000FC54 File Offset: 0x0000DE54
		public unsafe float detachAfter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVoodooAttachToUnit.NativeFieldInfoPtr_detachAfter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVoodooAttachToUnit.NativeFieldInfoPtr_detachAfter)) = value;
			}
		}

		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x06001B3D RID: 6973 RVA: 0x0006BB9C File Offset: 0x00069D9C
		// (set) Token: 0x06001B3E RID: 6974 RVA: 0x0000FC6F File Offset: 0x0000DE6F
		public unsafe Il2CppReferenceArray<GameObject> targets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVoodooAttachToUnit.NativeFieldInfoPtr_targets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVoodooAttachToUnit.NativeFieldInfoPtr_targets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000FB2 RID: 4018
		private static readonly IntPtr NativeFieldInfoPtr_voodooAnimator;

		// Token: 0x04000FB3 RID: 4019
		private static readonly IntPtr NativeFieldInfoPtr_detachAfter;

		// Token: 0x04000FB4 RID: 4020
		private static readonly IntPtr NativeFieldInfoPtr_targets;

		// Token: 0x04000FB5 RID: 4021
		private static readonly IntPtr NativeMethodInfoPtr_Event_AttachIndex_Public_Void_Int32_0;

		// Token: 0x04000FB6 RID: 4022
		private static readonly IntPtr NativeMethodInfoPtr_DetachAfter_Private_Static_IEnumerator_Transform_Single_0;

		// Token: 0x04000FB7 RID: 4023
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200043B RID: 1083
		[ObfuscatedName("worm.client.match.render.WormVoodooAttachToUnit+<DetachAfter>d__4")]
		public sealed class _DetachAfter_d__4 : global::Il2CppSystem.Object
		{
			// Token: 0x06002D08 RID: 11528 RVA: 0x000A09D4 File Offset: 0x0009EBD4
			// Note: this type is marked as 'beforefieldinit'.
			static _DetachAfter_d__4()
			{
				Il2CppClassPointerStore<WormVoodooAttachToUnit._DetachAfter_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormVoodooAttachToUnit>.NativeClassPtr, "<DetachAfter>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormVoodooAttachToUnit._DetachAfter_d__4>.NativeClassPtr);
				WormVoodooAttachToUnit._DetachAfter_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormVoodooAttachToUnit._DetachAfter_d__4>.NativeClassPtr, "<>1__state");
				WormVoodooAttachToUnit._DetachAfter_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormVoodooAttachToUnit._DetachAfter_d__4>.NativeClassPtr, "<>2__current");
				WormVoodooAttachToUnit._DetachAfter_d__4.NativeFieldInfoPtr_seconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormVoodooAttachToUnit._DetachAfter_d__4>.NativeClassPtr, "seconds");
				WormVoodooAttachToUnit._DetachAfter_d__4.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormVoodooAttachToUnit._DetachAfter_d__4>.NativeClassPtr, "target");
				WormVoodooAttachToUnit._DetachAfter_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVoodooAttachToUnit._DetachAfter_d__4>.NativeClassPtr, 100667260);
				WormVoodooAttachToUnit._DetachAfter_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVoodooAttachToUnit._DetachAfter_d__4>.NativeClassPtr, 100667261);
				WormVoodooAttachToUnit._DetachAfter_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVoodooAttachToUnit._DetachAfter_d__4>.NativeClassPtr, 100667262);
				WormVoodooAttachToUnit._DetachAfter_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVoodooAttachToUnit._DetachAfter_d__4>.NativeClassPtr, 100667263);
				WormVoodooAttachToUnit._DetachAfter_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVoodooAttachToUnit._DetachAfter_d__4>.NativeClassPtr, 100667264);
				WormVoodooAttachToUnit._DetachAfter_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVoodooAttachToUnit._DetachAfter_d__4>.NativeClassPtr, 100667265);
			}

			// Token: 0x06002D09 RID: 11529 RVA: 0x000A0AC8 File Offset: 0x0009ECC8
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DetachAfter_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormVoodooAttachToUnit._DetachAfter_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVoodooAttachToUnit._DetachAfter_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002D0A RID: 11530 RVA: 0x000A0B10 File Offset: 0x0009ED10
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVoodooAttachToUnit._DetachAfter_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D0B RID: 11531 RVA: 0x000A0B44 File Offset: 0x0009ED44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724201, XrefRangeEnd = 724207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVoodooAttachToUnit._DetachAfter_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000CF1 RID: 3313
			// (get) Token: 0x06002D0C RID: 11532 RVA: 0x000A0B80 File Offset: 0x0009ED80
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVoodooAttachToUnit._DetachAfter_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002D0D RID: 11533 RVA: 0x000A0BC0 File Offset: 0x0009EDC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724207, XrefRangeEnd = 724212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVoodooAttachToUnit._DetachAfter_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000CF2 RID: 3314
			// (get) Token: 0x06002D0E RID: 11534 RVA: 0x000A0BF4 File Offset: 0x0009EDF4
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVoodooAttachToUnit._DetachAfter_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002D0F RID: 11535 RVA: 0x000186CA File Offset: 0x000168CA
			public _DetachAfter_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000CED RID: 3309
			// (get) Token: 0x06002D10 RID: 11536 RVA: 0x000A0C34 File Offset: 0x0009EE34
			// (set) Token: 0x06002D11 RID: 11537 RVA: 0x000186D3 File Offset: 0x000168D3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVoodooAttachToUnit._DetachAfter_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVoodooAttachToUnit._DetachAfter_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000CEE RID: 3310
			// (get) Token: 0x06002D12 RID: 11538 RVA: 0x000A0C5C File Offset: 0x0009EE5C
			// (set) Token: 0x06002D13 RID: 11539 RVA: 0x000186EE File Offset: 0x000168EE
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVoodooAttachToUnit._DetachAfter_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVoodooAttachToUnit._DetachAfter_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CEF RID: 3311
			// (get) Token: 0x06002D14 RID: 11540 RVA: 0x000A0C8C File Offset: 0x0009EE8C
			// (set) Token: 0x06002D15 RID: 11541 RVA: 0x0001870D File Offset: 0x0001690D
			public unsafe float seconds
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVoodooAttachToUnit._DetachAfter_d__4.NativeFieldInfoPtr_seconds);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVoodooAttachToUnit._DetachAfter_d__4.NativeFieldInfoPtr_seconds)) = value;
				}
			}

			// Token: 0x17000CF0 RID: 3312
			// (get) Token: 0x06002D16 RID: 11542 RVA: 0x000A0CB4 File Offset: 0x0009EEB4
			// (set) Token: 0x06002D17 RID: 11543 RVA: 0x00018728 File Offset: 0x00016928
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVoodooAttachToUnit._DetachAfter_d__4.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVoodooAttachToUnit._DetachAfter_d__4.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001A33 RID: 6707
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001A34 RID: 6708
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001A35 RID: 6709
			private static readonly IntPtr NativeFieldInfoPtr_seconds;

			// Token: 0x04001A36 RID: 6710
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04001A37 RID: 6711
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001A38 RID: 6712
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001A39 RID: 6713
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001A3A RID: 6714
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001A3B RID: 6715
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001A3C RID: 6716
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
