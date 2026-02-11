using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;

namespace Steamworks.ServerList
{
	// Token: 0x020000DC RID: 220
	public class IpList : Internet
	{
		// Token: 0x06000E99 RID: 3737 RVA: 0x0005ACF4 File Offset: 0x00058EF4
		// Note: this type is marked as 'beforefieldinit'.
		static IpList()
		{
			Il2CppClassPointerStore<IpList>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.ServerList", "IpList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IpList>.NativeClassPtr);
			IpList.NativeFieldInfoPtr_Ips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IpList>.NativeClassPtr, "Ips");
			IpList.NativeFieldInfoPtr_wantsCancel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IpList>.NativeClassPtr, "wantsCancel");
			IpList.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IpList>.NativeClassPtr, 100666721);
			IpList.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IpList>.NativeClassPtr, 100666722);
			IpList.NativeMethodInfoPtr_RunQueryAsync_Public_Virtual_Task_1_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IpList>.NativeClassPtr, 100666723);
			IpList.NativeMethodInfoPtr_Cancel_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IpList>.NativeClassPtr, 100666724);
		}

		// Token: 0x06000E9A RID: 3738 RVA: 0x0005AD9C File Offset: 0x00058F9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950060, XrefRangeEnd = 950072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IpList(IEnumerable<string> list)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IpList>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IpList.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E9B RID: 3739 RVA: 0x0005ADE8 File Offset: 0x00058FE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950072, XrefRangeEnd = 950096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IpList([Optional] Il2CppStringArray list)
		{
			if (list == null)
			{
				list = new Il2CppStringArray(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IpList>.NativeClassPtr));
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IpList.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E9C RID: 3740 RVA: 0x0005AE40 File Offset: 0x00059040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950096, XrefRangeEnd = 950110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task<bool> RunQueryAsync(float timeoutSeconds = 10f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref timeoutSeconds;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IpList.NativeMethodInfoPtr_RunQueryAsync_Public_Virtual_Task_1_Boolean_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
			}
		}

		// Token: 0x06000E9D RID: 3741 RVA: 0x0005AE98 File Offset: 0x00059098
		[CallerCount(0)]
		public unsafe override void Cancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IpList.NativeMethodInfoPtr_Cancel_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E9E RID: 3742 RVA: 0x00003EA1 File Offset: 0x000020A1
		public IpList(params string[] list)
			: this(new Il2CppStringArray(list))
		{
		}

		// Token: 0x06000E9F RID: 3743 RVA: 0x00003EAF File Offset: 0x000020AF
		public IpList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000EA0 RID: 3744 RVA: 0x0005AED4 File Offset: 0x000590D4
		// (set) Token: 0x06000EA1 RID: 3745 RVA: 0x00003EB8 File Offset: 0x000020B8
		public unsafe List<string> Ips
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IpList.NativeFieldInfoPtr_Ips);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IpList.NativeFieldInfoPtr_Ips), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000EA2 RID: 3746 RVA: 0x0005AF04 File Offset: 0x00059104
		// (set) Token: 0x06000EA3 RID: 3747 RVA: 0x00003ED7 File Offset: 0x000020D7
		public unsafe bool wantsCancel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IpList.NativeFieldInfoPtr_wantsCancel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IpList.NativeFieldInfoPtr_wantsCancel)) = value;
			}
		}

		// Token: 0x040014B3 RID: 5299
		private static readonly IntPtr NativeFieldInfoPtr_Ips;

		// Token: 0x040014B4 RID: 5300
		private static readonly IntPtr NativeFieldInfoPtr_wantsCancel;

		// Token: 0x040014B5 RID: 5301
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_String_0;

		// Token: 0x040014B6 RID: 5302
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_0;

		// Token: 0x040014B7 RID: 5303
		private static readonly IntPtr NativeMethodInfoPtr_RunQueryAsync_Public_Virtual_Task_1_Boolean_Single_0;

		// Token: 0x040014B8 RID: 5304
		private static readonly IntPtr NativeMethodInfoPtr_Cancel_Public_Virtual_Void_0;

		// Token: 0x0200029A RID: 666
		[ObfuscatedName("Steamworks.ServerList.IpList+<RunQueryAsync>d__4")]
		public sealed class _RunQueryAsync_d__4 : ValueType
		{
			// Token: 0x060021E0 RID: 8672 RVA: 0x00092570 File Offset: 0x00090770
			// Note: this type is marked as 'beforefieldinit'.
			static _RunQueryAsync_d__4()
			{
				Il2CppClassPointerStore<IpList._RunQueryAsync_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IpList>.NativeClassPtr, "<RunQueryAsync>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IpList._RunQueryAsync_d__4>.NativeClassPtr);
				IpList._RunQueryAsync_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IpList._RunQueryAsync_d__4>.NativeClassPtr, "<>1__state");
				IpList._RunQueryAsync_d__4.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IpList._RunQueryAsync_d__4>.NativeClassPtr, "<>t__builder");
				IpList._RunQueryAsync_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IpList._RunQueryAsync_d__4>.NativeClassPtr, "<>4__this");
				IpList._RunQueryAsync_d__4.NativeFieldInfoPtr_timeoutSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IpList._RunQueryAsync_d__4>.NativeClassPtr, "timeoutSeconds");
				IpList._RunQueryAsync_d__4.NativeFieldInfoPtr__blockSize_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IpList._RunQueryAsync_d__4>.NativeClassPtr, "<blockSize>5__2");
				IpList._RunQueryAsync_d__4.NativeFieldInfoPtr__pointer_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IpList._RunQueryAsync_d__4>.NativeClassPtr, "<pointer>5__3");
				IpList._RunQueryAsync_d__4.NativeFieldInfoPtr__ips_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IpList._RunQueryAsync_d__4>.NativeClassPtr, "<ips>5__4");
				IpList._RunQueryAsync_d__4.NativeFieldInfoPtr__sublist_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IpList._RunQueryAsync_d__4>.NativeClassPtr, "<sublist>5__5");
				IpList._RunQueryAsync_d__4.NativeFieldInfoPtr__list_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IpList._RunQueryAsync_d__4>.NativeClassPtr, "<list>5__6");
				IpList._RunQueryAsync_d__4.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IpList._RunQueryAsync_d__4>.NativeClassPtr, "<>u__1");
				IpList._RunQueryAsync_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IpList._RunQueryAsync_d__4>.NativeClassPtr, 100666725);
				IpList._RunQueryAsync_d__4.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IpList._RunQueryAsync_d__4>.NativeClassPtr, 100666726);
			}

			// Token: 0x060021E1 RID: 8673 RVA: 0x0009268C File Offset: 0x0009088C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949955, XrefRangeEnd = 950054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IpList._RunQueryAsync_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060021E2 RID: 8674 RVA: 0x000926C4 File Offset: 0x000908C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950054, XrefRangeEnd = 950060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IpList._RunQueryAsync_d__4.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060021E3 RID: 8675 RVA: 0x0000D944 File Offset: 0x0000BB44
			public _RunQueryAsync_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060021E4 RID: 8676 RVA: 0x0000D94D File Offset: 0x0000BB4D
			public _RunQueryAsync_d__4()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IpList._RunQueryAsync_d__4>.NativeClassPtr))
			{
			}

			// Token: 0x170008D3 RID: 2259
			// (get) Token: 0x060021E5 RID: 8677 RVA: 0x0009270C File Offset: 0x0009090C
			// (set) Token: 0x060021E6 RID: 8678 RVA: 0x0000D95F File Offset: 0x0000BB5F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IpList._RunQueryAsync_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IpList._RunQueryAsync_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008D4 RID: 2260
			// (get) Token: 0x060021E7 RID: 8679 RVA: 0x00092734 File Offset: 0x00090934
			// (set) Token: 0x060021E8 RID: 8680 RVA: 0x0000D97A File Offset: 0x0000BB7A
			public AsyncTaskMethodBuilder<bool> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IpList._RunQueryAsync_d__4.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IpList._RunQueryAsync_d__4.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008D5 RID: 2261
			// (get) Token: 0x060021E9 RID: 8681 RVA: 0x00092764 File Offset: 0x00090964
			// (set) Token: 0x060021EA RID: 8682 RVA: 0x0000D9A8 File Offset: 0x0000BBA8
			public unsafe IpList __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IpList._RunQueryAsync_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IpList>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IpList._RunQueryAsync_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008D6 RID: 2262
			// (get) Token: 0x060021EB RID: 8683 RVA: 0x00092794 File Offset: 0x00090994
			// (set) Token: 0x060021EC RID: 8684 RVA: 0x0000D9C7 File Offset: 0x0000BBC7
			public unsafe float timeoutSeconds
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IpList._RunQueryAsync_d__4.NativeFieldInfoPtr_timeoutSeconds);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IpList._RunQueryAsync_d__4.NativeFieldInfoPtr_timeoutSeconds)) = value;
				}
			}

			// Token: 0x170008D7 RID: 2263
			// (get) Token: 0x060021ED RID: 8685 RVA: 0x000927BC File Offset: 0x000909BC
			// (set) Token: 0x060021EE RID: 8686 RVA: 0x0000D9E2 File Offset: 0x0000BBE2
			public unsafe int _blockSize_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IpList._RunQueryAsync_d__4.NativeFieldInfoPtr__blockSize_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IpList._RunQueryAsync_d__4.NativeFieldInfoPtr__blockSize_5__2)) = value;
				}
			}

			// Token: 0x170008D8 RID: 2264
			// (get) Token: 0x060021EF RID: 8687 RVA: 0x000927E4 File Offset: 0x000909E4
			// (set) Token: 0x060021F0 RID: 8688 RVA: 0x0000D9FD File Offset: 0x0000BBFD
			public unsafe int _pointer_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IpList._RunQueryAsync_d__4.NativeFieldInfoPtr__pointer_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IpList._RunQueryAsync_d__4.NativeFieldInfoPtr__pointer_5__3)) = value;
				}
			}

			// Token: 0x170008D9 RID: 2265
			// (get) Token: 0x060021F1 RID: 8689 RVA: 0x0009280C File Offset: 0x00090A0C
			// (set) Token: 0x060021F2 RID: 8690 RVA: 0x0000DA18 File Offset: 0x0000BC18
			public unsafe Il2CppStringArray _ips_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IpList._RunQueryAsync_d__4.NativeFieldInfoPtr__ips_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IpList._RunQueryAsync_d__4.NativeFieldInfoPtr__ips_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008DA RID: 2266
			// (get) Token: 0x060021F3 RID: 8691 RVA: 0x0009283C File Offset: 0x00090A3C
			// (set) Token: 0x060021F4 RID: 8692 RVA: 0x0000DA37 File Offset: 0x0000BC37
			public unsafe IEnumerable<string> _sublist_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IpList._RunQueryAsync_d__4.NativeFieldInfoPtr__sublist_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IpList._RunQueryAsync_d__4.NativeFieldInfoPtr__sublist_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008DB RID: 2267
			// (get) Token: 0x060021F5 RID: 8693 RVA: 0x0009286C File Offset: 0x00090A6C
			// (set) Token: 0x060021F6 RID: 8694 RVA: 0x0000DA56 File Offset: 0x0000BC56
			public unsafe Internet _list_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IpList._RunQueryAsync_d__4.NativeFieldInfoPtr__list_5__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Internet>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IpList._RunQueryAsync_d__4.NativeFieldInfoPtr__list_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008DC RID: 2268
			// (get) Token: 0x060021F7 RID: 8695 RVA: 0x0009289C File Offset: 0x00090A9C
			// (set) Token: 0x060021F8 RID: 8696 RVA: 0x0000DA75 File Offset: 0x0000BC75
			public TaskAwaiter<bool> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IpList._RunQueryAsync_d__4.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<bool>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IpList._RunQueryAsync_d__4.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<bool>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400237F RID: 9087
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002380 RID: 9088
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04002381 RID: 9089
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002382 RID: 9090
			private static readonly IntPtr NativeFieldInfoPtr_timeoutSeconds;

			// Token: 0x04002383 RID: 9091
			private static readonly IntPtr NativeFieldInfoPtr__blockSize_5__2;

			// Token: 0x04002384 RID: 9092
			private static readonly IntPtr NativeFieldInfoPtr__pointer_5__3;

			// Token: 0x04002385 RID: 9093
			private static readonly IntPtr NativeFieldInfoPtr__ips_5__4;

			// Token: 0x04002386 RID: 9094
			private static readonly IntPtr NativeFieldInfoPtr__sublist_5__5;

			// Token: 0x04002387 RID: 9095
			private static readonly IntPtr NativeFieldInfoPtr__list_5__6;

			// Token: 0x04002388 RID: 9096
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04002389 RID: 9097
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400238A RID: 9098
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
