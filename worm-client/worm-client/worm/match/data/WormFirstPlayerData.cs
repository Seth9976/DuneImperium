using System;
using Canis.attributes;
using dwd.core.data.composition;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace worm.match.data
{
	// Token: 0x0200018C RID: 396
	public class WormFirstPlayerData : VersionedDataComponent
	{
		// Token: 0x060011BE RID: 4542 RVA: 0x0004DAE0 File Offset: 0x0004BCE0
		// Note: this type is marked as 'beforefieldinit'.
		static WormFirstPlayerData()
		{
			Il2CppClassPointerStore<WormFirstPlayerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.data", "WormFirstPlayerData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormFirstPlayerData>.NativeClassPtr);
			WormFirstPlayerData.NativeFieldInfoPtr_firstPlayerAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFirstPlayerData>.NativeClassPtr, "firstPlayerAttribute");
			WormFirstPlayerData.NativeMethodInfoPtr_get_firstPlayer_Public_get_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFirstPlayerData>.NativeClassPtr, 100665744);
			WormFirstPlayerData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFirstPlayerData>.NativeClassPtr, 100665745);
			WormFirstPlayerData.NativeMethodInfoPtr__ctor_Public_Void_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFirstPlayerData>.NativeClassPtr, 100665746);
			WormFirstPlayerData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFirstPlayerData>.NativeClassPtr, 100665747);
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x060011BF RID: 4543 RVA: 0x0004DB74 File Offset: 0x0004BD74
		public unsafe Nullable<bool> firstPlayer
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 711537, RefRangeEnd = 711538, XrefRangeStart = 711533, XrefRangeEnd = 711537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFirstPlayerData.NativeMethodInfoPtr_get_firstPlayer_Public_get_Nullable_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<bool>(intPtr);
			}
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x060011C0 RID: 4544 RVA: 0x0004DBAC File Offset: 0x0004BDAC
		public unsafe override ulong Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 711538, XrefRangeEnd = 711542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormFirstPlayerData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011C1 RID: 4545 RVA: 0x0004DBF4 File Offset: 0x0004BDF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 711549, RefRangeEnd = 711550, XrefRangeStart = 711542, XrefRangeEnd = 711549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormFirstPlayerData(EntityComponent entityComponent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormFirstPlayerData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityComponent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFirstPlayerData.NativeMethodInfoPtr__ctor_Public_Void_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011C2 RID: 4546 RVA: 0x0004DC40 File Offset: 0x0004BE40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 711550, XrefRangeEnd = 711561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormFirstPlayerData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060011C3 RID: 4547 RVA: 0x0000B436 File Offset: 0x00009636
		public WormFirstPlayerData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x060011C4 RID: 4548 RVA: 0x0004DC84 File Offset: 0x0004BE84
		// (set) Token: 0x060011C5 RID: 4549 RVA: 0x0000B43F File Offset: 0x0000963F
		public unsafe IAttribute<Nullable<bool>> firstPlayerAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFirstPlayerData.NativeFieldInfoPtr_firstPlayerAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFirstPlayerData.NativeFieldInfoPtr_firstPlayerAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A3E RID: 2622
		private static readonly IntPtr NativeFieldInfoPtr_firstPlayerAttribute;

		// Token: 0x04000A3F RID: 2623
		private static readonly IntPtr NativeMethodInfoPtr_get_firstPlayer_Public_get_Nullable_1_Boolean_0;

		// Token: 0x04000A40 RID: 2624
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0;

		// Token: 0x04000A41 RID: 2625
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityComponent_0;

		// Token: 0x04000A42 RID: 2626
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
