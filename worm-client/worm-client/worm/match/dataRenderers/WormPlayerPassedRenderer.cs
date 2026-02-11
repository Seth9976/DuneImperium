using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using lotus;
using UnityEngine;
using worm.match.data;

namespace worm.match.dataRenderers
{
	// Token: 0x0200014F RID: 335
	public class WormPlayerPassedRenderer : VersionedView<WormConflictPlayerStateData>
	{
		// Token: 0x06000EF9 RID: 3833 RVA: 0x00045224 File Offset: 0x00043424
		// Note: this type is marked as 'beforefieldinit'.
		static WormPlayerPassedRenderer()
		{
			Il2CppClassPointerStore<WormPlayerPassedRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormPlayerPassedRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayerPassedRenderer>.NativeClassPtr);
			WormPlayerPassedRenderer.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerPassedRenderer>.NativeClassPtr, "animator");
			WormPlayerPassedRenderer.NativeFieldInfoPtr_localID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerPassedRenderer>.NativeClassPtr, "localID");
			WormPlayerPassedRenderer.NativeFieldInfoPtr_conflictPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerPassedRenderer>.NativeClassPtr, "conflictPass");
			WormPlayerPassedRenderer.NativeFieldInfoPtr_animatorParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerPassedRenderer>.NativeClassPtr, "animatorParam");
			WormPlayerPassedRenderer.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerPassedRenderer>.NativeClassPtr, "parent");
			WormPlayerPassedRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerPassedRenderer>.NativeClassPtr, 100665315);
			WormPlayerPassedRenderer.NativeMethodInfoPtr_Init_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerPassedRenderer>.NativeClassPtr, 100665316);
			WormPlayerPassedRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerPassedRenderer>.NativeClassPtr, 100665317);
			WormPlayerPassedRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerPassedRenderer>.NativeClassPtr, 100665318);
		}

		// Token: 0x06000EFA RID: 3834 RVA: 0x00045308 File Offset: 0x00043508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707219, XrefRangeEnd = 707229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormPlayerPassedRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EFB RID: 3835 RVA: 0x00045344 File Offset: 0x00043544
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707229, XrefRangeEnd = 707234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerPassedRenderer.NativeMethodInfoPtr_Init_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000EFC RID: 3836 RVA: 0x00045384 File Offset: 0x00043584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707234, XrefRangeEnd = 707246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormPlayerPassedRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EFD RID: 3837 RVA: 0x000453C0 File Offset: 0x000435C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707246, XrefRangeEnd = 707252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormPlayerPassedRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayerPassedRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerPassedRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EFE RID: 3838 RVA: 0x00009E09 File Offset: 0x00008009
		public WormPlayerPassedRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06000EFF RID: 3839 RVA: 0x000453FC File Offset: 0x000435FC
		// (set) Token: 0x06000F00 RID: 3840 RVA: 0x00009E12 File Offset: 0x00008012
		public unsafe Animator animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerPassedRenderer.NativeFieldInfoPtr_animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerPassedRenderer.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06000F01 RID: 3841 RVA: 0x0004542C File Offset: 0x0004362C
		// (set) Token: 0x06000F02 RID: 3842 RVA: 0x00009E31 File Offset: 0x00008031
		public unsafe AccountID localID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerPassedRenderer.NativeFieldInfoPtr_localID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerPassedRenderer.NativeFieldInfoPtr_localID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06000F03 RID: 3843 RVA: 0x0004545C File Offset: 0x0004365C
		// (set) Token: 0x06000F04 RID: 3844 RVA: 0x00009E50 File Offset: 0x00008050
		public unsafe int conflictPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerPassedRenderer.NativeFieldInfoPtr_conflictPass);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerPassedRenderer.NativeFieldInfoPtr_conflictPass)) = value;
			}
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06000F05 RID: 3845 RVA: 0x00045484 File Offset: 0x00043684
		// (set) Token: 0x06000F06 RID: 3846 RVA: 0x00009E6B File Offset: 0x0000806B
		public unsafe string animatorParam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerPassedRenderer.NativeFieldInfoPtr_animatorParam);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerPassedRenderer.NativeFieldInfoPtr_animatorParam), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06000F07 RID: 3847 RVA: 0x000454AC File Offset: 0x000436AC
		// (set) Token: 0x06000F08 RID: 3848 RVA: 0x00009E8A File Offset: 0x0000808A
		public unsafe EntityView parent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerPassedRenderer.NativeFieldInfoPtr_parent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerPassedRenderer.NativeFieldInfoPtr_parent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400089F RID: 2207
		private static readonly IntPtr NativeFieldInfoPtr_animator;

		// Token: 0x040008A0 RID: 2208
		private static readonly IntPtr NativeFieldInfoPtr_localID;

		// Token: 0x040008A1 RID: 2209
		private static readonly IntPtr NativeFieldInfoPtr_conflictPass;

		// Token: 0x040008A2 RID: 2210
		private static readonly IntPtr NativeFieldInfoPtr_animatorParam;

		// Token: 0x040008A3 RID: 2211
		private static readonly IntPtr NativeFieldInfoPtr_parent;

		// Token: 0x040008A4 RID: 2212
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040008A5 RID: 2213
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_IEnumerator_0;

		// Token: 0x040008A6 RID: 2214
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x040008A7 RID: 2215
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000399 RID: 921
		[ObfuscatedName("worm.match.dataRenderers.WormPlayerPassedRenderer+<Init>d__6")]
		public sealed class _Init_d__6 : global::Il2CppSystem.Object
		{
			// Token: 0x060024FF RID: 9471 RVA: 0x00087DF4 File Offset: 0x00085FF4
			// Note: this type is marked as 'beforefieldinit'.
			static _Init_d__6()
			{
				Il2CppClassPointerStore<WormPlayerPassedRenderer._Init_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlayerPassedRenderer>.NativeClassPtr, "<Init>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayerPassedRenderer._Init_d__6>.NativeClassPtr);
				WormPlayerPassedRenderer._Init_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerPassedRenderer._Init_d__6>.NativeClassPtr, "<>1__state");
				WormPlayerPassedRenderer._Init_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerPassedRenderer._Init_d__6>.NativeClassPtr, "<>2__current");
				WormPlayerPassedRenderer._Init_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerPassedRenderer._Init_d__6>.NativeClassPtr, "<>4__this");
				WormPlayerPassedRenderer._Init_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerPassedRenderer._Init_d__6>.NativeClassPtr, 100665319);
				WormPlayerPassedRenderer._Init_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerPassedRenderer._Init_d__6>.NativeClassPtr, 100665320);
				WormPlayerPassedRenderer._Init_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerPassedRenderer._Init_d__6>.NativeClassPtr, 100665321);
				WormPlayerPassedRenderer._Init_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerPassedRenderer._Init_d__6>.NativeClassPtr, 100665322);
				WormPlayerPassedRenderer._Init_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerPassedRenderer._Init_d__6>.NativeClassPtr, 100665323);
				WormPlayerPassedRenderer._Init_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerPassedRenderer._Init_d__6>.NativeClassPtr, 100665324);
			}

			// Token: 0x06002500 RID: 9472 RVA: 0x00087ED4 File Offset: 0x000860D4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Init_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayerPassedRenderer._Init_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerPassedRenderer._Init_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002501 RID: 9473 RVA: 0x00087F1C File Offset: 0x0008611C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerPassedRenderer._Init_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002502 RID: 9474 RVA: 0x00087F50 File Offset: 0x00086150
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707206, XrefRangeEnd = 707214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerPassedRenderer._Init_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000A49 RID: 2633
			// (get) Token: 0x06002503 RID: 9475 RVA: 0x00087F8C File Offset: 0x0008618C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerPassedRenderer._Init_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002504 RID: 9476 RVA: 0x00087FCC File Offset: 0x000861CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707214, XrefRangeEnd = 707219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerPassedRenderer._Init_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000A4A RID: 2634
			// (get) Token: 0x06002505 RID: 9477 RVA: 0x00088000 File Offset: 0x00086200
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerPassedRenderer._Init_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002506 RID: 9478 RVA: 0x000149FD File Offset: 0x00012BFD
			public _Init_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A46 RID: 2630
			// (get) Token: 0x06002507 RID: 9479 RVA: 0x00088040 File Offset: 0x00086240
			// (set) Token: 0x06002508 RID: 9480 RVA: 0x00014A06 File Offset: 0x00012C06
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerPassedRenderer._Init_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerPassedRenderer._Init_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000A47 RID: 2631
			// (get) Token: 0x06002509 RID: 9481 RVA: 0x00088068 File Offset: 0x00086268
			// (set) Token: 0x0600250A RID: 9482 RVA: 0x00014A21 File Offset: 0x00012C21
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerPassedRenderer._Init_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerPassedRenderer._Init_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A48 RID: 2632
			// (get) Token: 0x0600250B RID: 9483 RVA: 0x00088098 File Offset: 0x00086298
			// (set) Token: 0x0600250C RID: 9484 RVA: 0x00014A40 File Offset: 0x00012C40
			public unsafe WormPlayerPassedRenderer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerPassedRenderer._Init_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayerPassedRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerPassedRenderer._Init_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001539 RID: 5433
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400153A RID: 5434
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400153B RID: 5435
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400153C RID: 5436
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400153D RID: 5437
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400153E RID: 5438
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400153F RID: 5439
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001540 RID: 5440
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001541 RID: 5441
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
