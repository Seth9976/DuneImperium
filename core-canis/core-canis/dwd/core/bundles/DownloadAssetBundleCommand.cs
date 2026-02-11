using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine.Networking;

namespace dwd.core.bundles
{
	// Token: 0x020001FE RID: 510
	public sealed class DownloadAssetBundleCommand : Command
	{
		// Token: 0x06001C60 RID: 7264 RVA: 0x00083F3C File Offset: 0x0008213C
		// Note: this type is marked as 'beforefieldinit'.
		static DownloadAssetBundleCommand()
		{
			Il2CppClassPointerStore<DownloadAssetBundleCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.bundles", "DownloadAssetBundleCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DownloadAssetBundleCommand>.NativeClassPtr);
			DownloadAssetBundleCommand.NativeFieldInfoPtr_isInterupt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownloadAssetBundleCommand>.NativeClassPtr, "isInterupt");
			DownloadAssetBundleCommand.NativeFieldInfoPtr_useVerboseLogging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownloadAssetBundleCommand>.NativeClassPtr, "useVerboseLogging");
			DownloadAssetBundleCommand.NativeFieldInfoPtr_request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownloadAssetBundleCommand>.NativeClassPtr, "request");
			DownloadAssetBundleCommand.NativeMethodInfoPtr__ctor_Public_Void_Boolean_AssetBundleRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadAssetBundleCommand>.NativeClassPtr, 100667801);
			DownloadAssetBundleCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadAssetBundleCommand>.NativeClassPtr, 100667802);
			DownloadAssetBundleCommand.NativeMethodInfoPtr_GetWWW_Private_IEnumerator_AssetBundleRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadAssetBundleCommand>.NativeClassPtr, 100667803);
			DownloadAssetBundleCommand.NativeMethodInfoPtr_Interrupt_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadAssetBundleCommand>.NativeClassPtr, 100667804);
			DownloadAssetBundleCommand.NativeMethodInfoPtr_get_Interrupted_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadAssetBundleCommand>.NativeClassPtr, 100667805);
		}

		// Token: 0x06001C61 RID: 7265 RVA: 0x0008400C File Offset: 0x0008220C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885608, XrefRangeEnd = 885610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DownloadAssetBundleCommand(bool useVerboseLogging, AssetBundleRequest request)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DownloadAssetBundleCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref useVerboseLogging;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(request);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadAssetBundleCommand.NativeMethodInfoPtr__ctor_Public_Void_Boolean_AssetBundleRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C62 RID: 7266 RVA: 0x00084068 File Offset: 0x00082268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885610, XrefRangeEnd = 885615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadAssetBundleCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001C63 RID: 7267 RVA: 0x000840A8 File Offset: 0x000822A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885615, XrefRangeEnd = 885621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator GetWWW(AssetBundleRequest request)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadAssetBundleCommand.NativeMethodInfoPtr_GetWWW_Private_IEnumerator_AssetBundleRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06001C64 RID: 7268 RVA: 0x000840F8 File Offset: 0x000822F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885621, XrefRangeEnd = 885629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interrupt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadAssetBundleCommand.NativeMethodInfoPtr_Interrupt_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x06001C65 RID: 7269 RVA: 0x0008412C File Offset: 0x0008232C
		public unsafe bool Interrupted
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 308625, RefRangeEnd = 308626, XrefRangeStart = 308625, XrefRangeEnd = 308626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadAssetBundleCommand.NativeMethodInfoPtr_get_Interrupted_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C66 RID: 7270 RVA: 0x0000C38C File Offset: 0x0000A58C
		public DownloadAssetBundleCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x06001C67 RID: 7271 RVA: 0x00084168 File Offset: 0x00082368
		// (set) Token: 0x06001C68 RID: 7272 RVA: 0x0000C395 File Offset: 0x0000A595
		public unsafe bool isInterupt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DownloadAssetBundleCommand.NativeFieldInfoPtr_isInterupt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DownloadAssetBundleCommand.NativeFieldInfoPtr_isInterupt)) = value;
			}
		}

		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x06001C69 RID: 7273 RVA: 0x00084190 File Offset: 0x00082390
		// (set) Token: 0x06001C6A RID: 7274 RVA: 0x0000C3B0 File Offset: 0x0000A5B0
		public unsafe bool useVerboseLogging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DownloadAssetBundleCommand.NativeFieldInfoPtr_useVerboseLogging);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DownloadAssetBundleCommand.NativeFieldInfoPtr_useVerboseLogging)) = value;
			}
		}

		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x06001C6B RID: 7275 RVA: 0x000841B8 File Offset: 0x000823B8
		// (set) Token: 0x06001C6C RID: 7276 RVA: 0x0000C3CB File Offset: 0x0000A5CB
		public unsafe AssetBundleRequest request
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DownloadAssetBundleCommand.NativeFieldInfoPtr_request);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetBundleRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DownloadAssetBundleCommand.NativeFieldInfoPtr_request), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040013E2 RID: 5090
		private static readonly IntPtr NativeFieldInfoPtr_isInterupt;

		// Token: 0x040013E3 RID: 5091
		private static readonly IntPtr NativeFieldInfoPtr_useVerboseLogging;

		// Token: 0x040013E4 RID: 5092
		private static readonly IntPtr NativeFieldInfoPtr_request;

		// Token: 0x040013E5 RID: 5093
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_AssetBundleRequest_0;

		// Token: 0x040013E6 RID: 5094
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x040013E7 RID: 5095
		private static readonly IntPtr NativeMethodInfoPtr_GetWWW_Private_IEnumerator_AssetBundleRequest_0;

		// Token: 0x040013E8 RID: 5096
		private static readonly IntPtr NativeMethodInfoPtr_Interrupt_Public_Virtual_Final_New_Void_0;

		// Token: 0x040013E9 RID: 5097
		private static readonly IntPtr NativeMethodInfoPtr_get_Interrupted_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0200038F RID: 911
		[ObfuscatedName("dwd.core.bundles.DownloadAssetBundleCommand+<GetWWW>d__5")]
		public sealed class _GetWWW_d__5 : Object
		{
			// Token: 0x060028C1 RID: 10433 RVA: 0x000AB900 File Offset: 0x000A9B00
			// Note: this type is marked as 'beforefieldinit'.
			static _GetWWW_d__5()
			{
				Il2CppClassPointerStore<DownloadAssetBundleCommand._GetWWW_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DownloadAssetBundleCommand>.NativeClassPtr, "<GetWWW>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DownloadAssetBundleCommand._GetWWW_d__5>.NativeClassPtr);
				DownloadAssetBundleCommand._GetWWW_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownloadAssetBundleCommand._GetWWW_d__5>.NativeClassPtr, "<>1__state");
				DownloadAssetBundleCommand._GetWWW_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownloadAssetBundleCommand._GetWWW_d__5>.NativeClassPtr, "<>2__current");
				DownloadAssetBundleCommand._GetWWW_d__5.NativeFieldInfoPtr_request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownloadAssetBundleCommand._GetWWW_d__5>.NativeClassPtr, "request");
				DownloadAssetBundleCommand._GetWWW_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownloadAssetBundleCommand._GetWWW_d__5>.NativeClassPtr, "<>4__this");
				DownloadAssetBundleCommand._GetWWW_d__5.NativeFieldInfoPtr__wwwRequest_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownloadAssetBundleCommand._GetWWW_d__5>.NativeClassPtr, "<wwwRequest>5__2");
				DownloadAssetBundleCommand._GetWWW_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadAssetBundleCommand._GetWWW_d__5>.NativeClassPtr, 100667806);
				DownloadAssetBundleCommand._GetWWW_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadAssetBundleCommand._GetWWW_d__5>.NativeClassPtr, 100667807);
				DownloadAssetBundleCommand._GetWWW_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadAssetBundleCommand._GetWWW_d__5>.NativeClassPtr, 100667808);
				DownloadAssetBundleCommand._GetWWW_d__5.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadAssetBundleCommand._GetWWW_d__5>.NativeClassPtr, 100667809);
				DownloadAssetBundleCommand._GetWWW_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadAssetBundleCommand._GetWWW_d__5>.NativeClassPtr, 100667810);
				DownloadAssetBundleCommand._GetWWW_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadAssetBundleCommand._GetWWW_d__5>.NativeClassPtr, 100667811);
				DownloadAssetBundleCommand._GetWWW_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadAssetBundleCommand._GetWWW_d__5>.NativeClassPtr, 100667812);
			}

			// Token: 0x060028C2 RID: 10434 RVA: 0x000ABA1C File Offset: 0x000A9C1C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetWWW_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DownloadAssetBundleCommand._GetWWW_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadAssetBundleCommand._GetWWW_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060028C3 RID: 10435 RVA: 0x000ABA64 File Offset: 0x000A9C64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885503, XrefRangeEnd = 885508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadAssetBundleCommand._GetWWW_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060028C4 RID: 10436 RVA: 0x000ABA98 File Offset: 0x000A9C98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885508, XrefRangeEnd = 885557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadAssetBundleCommand._GetWWW_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060028C5 RID: 10437 RVA: 0x000ABAD4 File Offset: 0x000A9CD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885557, XrefRangeEnd = 885560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadAssetBundleCommand._GetWWW_d__5.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B94 RID: 2964
			// (get) Token: 0x060028C6 RID: 10438 RVA: 0x000ABB08 File Offset: 0x000A9D08
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadAssetBundleCommand._GetWWW_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060028C7 RID: 10439 RVA: 0x000ABB48 File Offset: 0x000A9D48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885560, XrefRangeEnd = 885565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadAssetBundleCommand._GetWWW_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B95 RID: 2965
			// (get) Token: 0x060028C8 RID: 10440 RVA: 0x000ABB7C File Offset: 0x000A9D7C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadAssetBundleCommand._GetWWW_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060028C9 RID: 10441 RVA: 0x00012842 File Offset: 0x00010A42
			public _GetWWW_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B8F RID: 2959
			// (get) Token: 0x060028CA RID: 10442 RVA: 0x000ABBBC File Offset: 0x000A9DBC
			// (set) Token: 0x060028CB RID: 10443 RVA: 0x0001284B File Offset: 0x00010A4B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DownloadAssetBundleCommand._GetWWW_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DownloadAssetBundleCommand._GetWWW_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000B90 RID: 2960
			// (get) Token: 0x060028CC RID: 10444 RVA: 0x000ABBE4 File Offset: 0x000A9DE4
			// (set) Token: 0x060028CD RID: 10445 RVA: 0x00012866 File Offset: 0x00010A66
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DownloadAssetBundleCommand._GetWWW_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DownloadAssetBundleCommand._GetWWW_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B91 RID: 2961
			// (get) Token: 0x060028CE RID: 10446 RVA: 0x000ABC14 File Offset: 0x000A9E14
			// (set) Token: 0x060028CF RID: 10447 RVA: 0x00012885 File Offset: 0x00010A85
			public unsafe AssetBundleRequest request
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DownloadAssetBundleCommand._GetWWW_d__5.NativeFieldInfoPtr_request);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetBundleRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DownloadAssetBundleCommand._GetWWW_d__5.NativeFieldInfoPtr_request), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B92 RID: 2962
			// (get) Token: 0x060028D0 RID: 10448 RVA: 0x000ABC44 File Offset: 0x000A9E44
			// (set) Token: 0x060028D1 RID: 10449 RVA: 0x000128A4 File Offset: 0x00010AA4
			public unsafe DownloadAssetBundleCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DownloadAssetBundleCommand._GetWWW_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DownloadAssetBundleCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DownloadAssetBundleCommand._GetWWW_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B93 RID: 2963
			// (get) Token: 0x060028D2 RID: 10450 RVA: 0x000ABC74 File Offset: 0x000A9E74
			// (set) Token: 0x060028D3 RID: 10451 RVA: 0x000128C3 File Offset: 0x00010AC3
			public unsafe UnityWebRequest _wwwRequest_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DownloadAssetBundleCommand._GetWWW_d__5.NativeFieldInfoPtr__wwwRequest_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DownloadAssetBundleCommand._GetWWW_d__5.NativeFieldInfoPtr__wwwRequest_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001B9E RID: 7070
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001B9F RID: 7071
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001BA0 RID: 7072
			private static readonly IntPtr NativeFieldInfoPtr_request;

			// Token: 0x04001BA1 RID: 7073
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001BA2 RID: 7074
			private static readonly IntPtr NativeFieldInfoPtr__wwwRequest_5__2;

			// Token: 0x04001BA3 RID: 7075
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001BA4 RID: 7076
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001BA5 RID: 7077
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001BA6 RID: 7078
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04001BA7 RID: 7079
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001BA8 RID: 7080
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001BA9 RID: 7081
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000390 RID: 912
		[ObfuscatedName("dwd.core.bundles.DownloadAssetBundleCommand+<execute>d__4")]
		public sealed class _execute_d__4 : Object
		{
			// Token: 0x060028D4 RID: 10452 RVA: 0x000ABCA4 File Offset: 0x000A9EA4
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__4()
			{
				Il2CppClassPointerStore<DownloadAssetBundleCommand._execute_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DownloadAssetBundleCommand>.NativeClassPtr, "<execute>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DownloadAssetBundleCommand._execute_d__4>.NativeClassPtr);
				DownloadAssetBundleCommand._execute_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownloadAssetBundleCommand._execute_d__4>.NativeClassPtr, "<>1__state");
				DownloadAssetBundleCommand._execute_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownloadAssetBundleCommand._execute_d__4>.NativeClassPtr, "<>2__current");
				DownloadAssetBundleCommand._execute_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownloadAssetBundleCommand._execute_d__4>.NativeClassPtr, "<>4__this");
				DownloadAssetBundleCommand._execute_d__4.NativeFieldInfoPtr__getWWW_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownloadAssetBundleCommand._execute_d__4>.NativeClassPtr, "<getWWW>5__2");
				DownloadAssetBundleCommand._execute_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadAssetBundleCommand._execute_d__4>.NativeClassPtr, 100667813);
				DownloadAssetBundleCommand._execute_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadAssetBundleCommand._execute_d__4>.NativeClassPtr, 100667814);
				DownloadAssetBundleCommand._execute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadAssetBundleCommand._execute_d__4>.NativeClassPtr, 100667815);
				DownloadAssetBundleCommand._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadAssetBundleCommand._execute_d__4>.NativeClassPtr, 100667816);
				DownloadAssetBundleCommand._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadAssetBundleCommand._execute_d__4>.NativeClassPtr, 100667817);
				DownloadAssetBundleCommand._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadAssetBundleCommand._execute_d__4>.NativeClassPtr, 100667818);
			}

			// Token: 0x060028D5 RID: 10453 RVA: 0x000ABD98 File Offset: 0x000A9F98
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DownloadAssetBundleCommand._execute_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadAssetBundleCommand._execute_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060028D6 RID: 10454 RVA: 0x000ABDE0 File Offset: 0x000A9FE0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadAssetBundleCommand._execute_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060028D7 RID: 10455 RVA: 0x000ABE14 File Offset: 0x000AA014
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885565, XrefRangeEnd = 885603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadAssetBundleCommand._execute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000B9A RID: 2970
			// (get) Token: 0x060028D8 RID: 10456 RVA: 0x000ABE50 File Offset: 0x000AA050
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadAssetBundleCommand._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060028D9 RID: 10457 RVA: 0x000ABE90 File Offset: 0x000AA090
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885603, XrefRangeEnd = 885608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadAssetBundleCommand._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B9B RID: 2971
			// (get) Token: 0x060028DA RID: 10458 RVA: 0x000ABEC4 File Offset: 0x000AA0C4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadAssetBundleCommand._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060028DB RID: 10459 RVA: 0x000128E2 File Offset: 0x00010AE2
			public _execute_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B96 RID: 2966
			// (get) Token: 0x060028DC RID: 10460 RVA: 0x000ABF04 File Offset: 0x000AA104
			// (set) Token: 0x060028DD RID: 10461 RVA: 0x000128EB File Offset: 0x00010AEB
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DownloadAssetBundleCommand._execute_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DownloadAssetBundleCommand._execute_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000B97 RID: 2967
			// (get) Token: 0x060028DE RID: 10462 RVA: 0x000ABF2C File Offset: 0x000AA12C
			// (set) Token: 0x060028DF RID: 10463 RVA: 0x00012906 File Offset: 0x00010B06
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DownloadAssetBundleCommand._execute_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DownloadAssetBundleCommand._execute_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B98 RID: 2968
			// (get) Token: 0x060028E0 RID: 10464 RVA: 0x000ABF5C File Offset: 0x000AA15C
			// (set) Token: 0x060028E1 RID: 10465 RVA: 0x00012925 File Offset: 0x00010B25
			public unsafe DownloadAssetBundleCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DownloadAssetBundleCommand._execute_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DownloadAssetBundleCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DownloadAssetBundleCommand._execute_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B99 RID: 2969
			// (get) Token: 0x060028E2 RID: 10466 RVA: 0x000ABF8C File Offset: 0x000AA18C
			// (set) Token: 0x060028E3 RID: 10467 RVA: 0x00012944 File Offset: 0x00010B44
			public unsafe IEnumerator _getWWW_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DownloadAssetBundleCommand._execute_d__4.NativeFieldInfoPtr__getWWW_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DownloadAssetBundleCommand._execute_d__4.NativeFieldInfoPtr__getWWW_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001BAA RID: 7082
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001BAB RID: 7083
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001BAC RID: 7084
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001BAD RID: 7085
			private static readonly IntPtr NativeFieldInfoPtr__getWWW_5__2;

			// Token: 0x04001BAE RID: 7086
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001BAF RID: 7087
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001BB0 RID: 7088
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001BB1 RID: 7089
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001BB2 RID: 7090
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001BB3 RID: 7091
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
