using System;
using dwd.core.direBytes.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace dwd.core.direBytes
{
	// Token: 0x02000009 RID: 9
	public class DireByteNewTileBehaviour : VersionedSubscriber<DireByteTileHashData>
	{
		// Token: 0x06000032 RID: 50 RVA: 0x00003FA0 File Offset: 0x000021A0
		// Note: this type is marked as 'beforefieldinit'.
		static DireByteNewTileBehaviour()
		{
			Il2CppClassPointerStore<DireByteNewTileBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("direbytes.dll", "dwd.core.direBytes", "DireByteNewTileBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DireByteNewTileBehaviour>.NativeClassPtr);
			DireByteNewTileBehaviour.NativeFieldInfoPtr_isNewTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireByteNewTileBehaviour>.NativeClassPtr, "isNewTile");
			DireByteNewTileBehaviour.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireByteNewTileBehaviour>.NativeClassPtr, 100663320);
			DireByteNewTileBehaviour.NativeMethodInfoPtr_Event_DireByteTileSeen_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireByteNewTileBehaviour>.NativeClassPtr, 100663321);
			DireByteNewTileBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireByteNewTileBehaviour>.NativeClassPtr, 100663322);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00004020 File Offset: 0x00002220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233524, XrefRangeEnd = 1233528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DireByteNewTileBehaviour.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x0000405C File Offset: 0x0000225C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233528, XrefRangeEnd = 1233532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_DireByteTileSeen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireByteNewTileBehaviour.NativeMethodInfoPtr_Event_DireByteTileSeen_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00004090 File Offset: 0x00002290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233532, XrefRangeEnd = 1233540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DireByteNewTileBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DireByteNewTileBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireByteNewTileBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000021E0 File Offset: 0x000003E0
		public DireByteNewTileBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000037 RID: 55 RVA: 0x000040CC File Offset: 0x000022CC
		// (set) Token: 0x06000038 RID: 56 RVA: 0x000021E9 File Offset: 0x000003E9
		public unsafe UnityEventBool isNewTile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteNewTileBehaviour.NativeFieldInfoPtr_isNewTile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEventBool>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteNewTileBehaviour.NativeFieldInfoPtr_isNewTile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeFieldInfoPtr_isNewTile;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeMethodInfoPtr_Event_DireByteTileSeen_Public_Void_0;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
