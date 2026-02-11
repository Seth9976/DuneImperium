using System;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace lotus
{
	// Token: 0x0200006D RID: 109
	public class PathPreviewMoveCommand : VoodooMoveCommand
	{
		// Token: 0x0600065C RID: 1628 RVA: 0x0001E59C File Offset: 0x0001C79C
		// Note: this type is marked as 'beforefieldinit'.
		static PathPreviewMoveCommand()
		{
			Il2CppClassPointerStore<PathPreviewMoveCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "PathPreviewMoveCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathPreviewMoveCommand>.NativeClassPtr);
			PathPreviewMoveCommand.NativeFieldInfoPtr_initData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathPreviewMoveCommand>.NativeClassPtr, "initData");
			PathPreviewMoveCommand.NativeFieldInfoPtr_waitingOnDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathPreviewMoveCommand>.NativeClassPtr, "waitingOnDelay");
			PathPreviewMoveCommand.NativeFieldInfoPtr_viewsToDespawnAfterDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathPreviewMoveCommand>.NativeClassPtr, "viewsToDespawnAfterDelay");
			PathPreviewMoveCommand.NativeMethodInfoPtr__ctor_Public_Void_PathPreviewContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathPreviewMoveCommand>.NativeClassPtr, 100664161);
			PathPreviewMoveCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathPreviewMoveCommand>.NativeClassPtr, 100664162);
			PathPreviewMoveCommand.NativeMethodInfoPtr_findEntity_Private_Static_EntityComponent_Entities_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathPreviewMoveCommand>.NativeClassPtr, 100664163);
			PathPreviewMoveCommand.NativeMethodInfoPtr_Release_Public_Virtual_Void_UnitView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathPreviewMoveCommand>.NativeClassPtr, 100664164);
			PathPreviewMoveCommand.NativeMethodInfoPtr_cleanupView_Private_Void_UnitView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathPreviewMoveCommand>.NativeClassPtr, 100664165);
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x0001E66C File Offset: 0x0001C86C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1112943, XrefRangeEnd = 1112952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PathPreviewMoveCommand(PathPreviewContext ppd)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PathPreviewMoveCommand>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ppd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathPreviewMoveCommand.NativeMethodInfoPtr__ctor_Public_Void_PathPreviewContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x0001E6B8 File Offset: 0x0001C8B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1112952, XrefRangeEnd = 1112957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PathPreviewMoveCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x0001E704 File Offset: 0x0001C904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1112957, XrefRangeEnd = 1112958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EntityComponent findEntity(Entities entities, string pile)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entities);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pile);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathPreviewMoveCommand.NativeMethodInfoPtr_findEntity_Private_Static_EntityComponent_Entities_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x0001E75C File Offset: 0x0001C95C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1112958, XrefRangeEnd = 1112965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Release(UnitView view)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(view);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PathPreviewMoveCommand.NativeMethodInfoPtr_Release_Public_Virtual_Void_UnitView_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x0001E7AC File Offset: 0x0001C9AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1112965, XrefRangeEnd = 1112969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void cleanupView(UnitView view)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(view);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathPreviewMoveCommand.NativeMethodInfoPtr_cleanupView_Private_Void_UnitView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x00005273 File Offset: 0x00003473
		public PathPreviewMoveCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06000663 RID: 1635 RVA: 0x0001E7F0 File Offset: 0x0001C9F0
		// (set) Token: 0x06000664 RID: 1636 RVA: 0x0000527C File Offset: 0x0000347C
		public unsafe PathPreviewContext initData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathPreviewMoveCommand.NativeFieldInfoPtr_initData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PathPreviewContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathPreviewMoveCommand.NativeFieldInfoPtr_initData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000665 RID: 1637 RVA: 0x0001E820 File Offset: 0x0001CA20
		// (set) Token: 0x06000666 RID: 1638 RVA: 0x0000529B File Offset: 0x0000349B
		public unsafe bool waitingOnDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathPreviewMoveCommand.NativeFieldInfoPtr_waitingOnDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathPreviewMoveCommand.NativeFieldInfoPtr_waitingOnDelay)) = value;
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000667 RID: 1639 RVA: 0x0001E848 File Offset: 0x0001CA48
		// (set) Token: 0x06000668 RID: 1640 RVA: 0x000052B6 File Offset: 0x000034B6
		public unsafe List<UnitView> viewsToDespawnAfterDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathPreviewMoveCommand.NativeFieldInfoPtr_viewsToDespawnAfterDelay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UnitView>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathPreviewMoveCommand.NativeFieldInfoPtr_viewsToDespawnAfterDelay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003F8 RID: 1016
		private static readonly IntPtr NativeFieldInfoPtr_initData;

		// Token: 0x040003F9 RID: 1017
		private static readonly IntPtr NativeFieldInfoPtr_waitingOnDelay;

		// Token: 0x040003FA RID: 1018
		private static readonly IntPtr NativeFieldInfoPtr_viewsToDespawnAfterDelay;

		// Token: 0x040003FB RID: 1019
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PathPreviewContext_0;

		// Token: 0x040003FC RID: 1020
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x040003FD RID: 1021
		private static readonly IntPtr NativeMethodInfoPtr_findEntity_Private_Static_EntityComponent_Entities_String_0;

		// Token: 0x040003FE RID: 1022
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Virtual_Void_UnitView_0;

		// Token: 0x040003FF RID: 1023
		private static readonly IntPtr NativeMethodInfoPtr_cleanupView_Private_Void_UnitView_0;

		// Token: 0x020000EF RID: 239
		[ObfuscatedName("lotus.PathPreviewMoveCommand+<execute>d__4")]
		public sealed class _execute_d__4 : Object
		{
			// Token: 0x06000C6D RID: 3181 RVA: 0x00031B14 File Offset: 0x0002FD14
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__4()
			{
				Il2CppClassPointerStore<PathPreviewMoveCommand._execute_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PathPreviewMoveCommand>.NativeClassPtr, "<execute>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathPreviewMoveCommand._execute_d__4>.NativeClassPtr);
				PathPreviewMoveCommand._execute_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathPreviewMoveCommand._execute_d__4>.NativeClassPtr, "<>1__state");
				PathPreviewMoveCommand._execute_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathPreviewMoveCommand._execute_d__4>.NativeClassPtr, "<>2__current");
				PathPreviewMoveCommand._execute_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathPreviewMoveCommand._execute_d__4>.NativeClassPtr, "<>4__this");
				PathPreviewMoveCommand._execute_d__4.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathPreviewMoveCommand._execute_d__4>.NativeClassPtr, "<i>5__2");
				PathPreviewMoveCommand._execute_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathPreviewMoveCommand._execute_d__4>.NativeClassPtr, 100664166);
				PathPreviewMoveCommand._execute_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathPreviewMoveCommand._execute_d__4>.NativeClassPtr, 100664167);
				PathPreviewMoveCommand._execute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathPreviewMoveCommand._execute_d__4>.NativeClassPtr, 100664168);
				PathPreviewMoveCommand._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathPreviewMoveCommand._execute_d__4>.NativeClassPtr, 100664169);
				PathPreviewMoveCommand._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathPreviewMoveCommand._execute_d__4>.NativeClassPtr, 100664170);
				PathPreviewMoveCommand._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathPreviewMoveCommand._execute_d__4>.NativeClassPtr, 100664171);
			}

			// Token: 0x06000C6E RID: 3182 RVA: 0x00031C08 File Offset: 0x0002FE08
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PathPreviewMoveCommand._execute_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathPreviewMoveCommand._execute_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000C6F RID: 3183 RVA: 0x00031C50 File Offset: 0x0002FE50
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathPreviewMoveCommand._execute_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000C70 RID: 3184 RVA: 0x00031C84 File Offset: 0x0002FE84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1112886, XrefRangeEnd = 1112938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathPreviewMoveCommand._execute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170003AC RID: 940
			// (get) Token: 0x06000C71 RID: 3185 RVA: 0x00031CC0 File Offset: 0x0002FEC0
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathPreviewMoveCommand._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000C72 RID: 3186 RVA: 0x00031D00 File Offset: 0x0002FF00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1112938, XrefRangeEnd = 1112943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathPreviewMoveCommand._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170003AD RID: 941
			// (get) Token: 0x06000C73 RID: 3187 RVA: 0x00031D34 File Offset: 0x0002FF34
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathPreviewMoveCommand._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000C74 RID: 3188 RVA: 0x000081D7 File Offset: 0x000063D7
			public _execute_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170003A8 RID: 936
			// (get) Token: 0x06000C75 RID: 3189 RVA: 0x00031D74 File Offset: 0x0002FF74
			// (set) Token: 0x06000C76 RID: 3190 RVA: 0x000081E0 File Offset: 0x000063E0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathPreviewMoveCommand._execute_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathPreviewMoveCommand._execute_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170003A9 RID: 937
			// (get) Token: 0x06000C77 RID: 3191 RVA: 0x00031D9C File Offset: 0x0002FF9C
			// (set) Token: 0x06000C78 RID: 3192 RVA: 0x000081FB File Offset: 0x000063FB
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathPreviewMoveCommand._execute_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathPreviewMoveCommand._execute_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003AA RID: 938
			// (get) Token: 0x06000C79 RID: 3193 RVA: 0x00031DCC File Offset: 0x0002FFCC
			// (set) Token: 0x06000C7A RID: 3194 RVA: 0x0000821A File Offset: 0x0000641A
			public unsafe PathPreviewMoveCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathPreviewMoveCommand._execute_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PathPreviewMoveCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathPreviewMoveCommand._execute_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003AB RID: 939
			// (get) Token: 0x06000C7B RID: 3195 RVA: 0x00031DFC File Offset: 0x0002FFFC
			// (set) Token: 0x06000C7C RID: 3196 RVA: 0x00008239 File Offset: 0x00006439
			public unsafe int _i_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathPreviewMoveCommand._execute_d__4.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathPreviewMoveCommand._execute_d__4.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x040007B9 RID: 1977
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040007BA RID: 1978
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040007BB RID: 1979
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040007BC RID: 1980
			private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x040007BD RID: 1981
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040007BE RID: 1982
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040007BF RID: 1983
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040007C0 RID: 1984
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040007C1 RID: 1985
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040007C2 RID: 1986
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
