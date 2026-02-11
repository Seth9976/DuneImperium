using System;
using dwd.core.session;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace dwd.core.cheats
{
	// Token: 0x020001EE RID: 494
	public sealed class Cheats : MonoBehaviour
	{
		// Token: 0x06001ACC RID: 6860 RVA: 0x0007E944 File Offset: 0x0007CB44
		// Note: this type is marked as 'beforefieldinit'.
		static Cheats()
		{
			Il2CppClassPointerStore<Cheats>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.cheats", "Cheats");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Cheats>.NativeClassPtr);
			Cheats.NativeFieldInfoPtr_multipleCheatArgumentDelimiter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cheats>.NativeClassPtr, "multipleCheatArgumentDelimiter");
			Cheats.NativeFieldInfoPtr_sessionWriter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cheats>.NativeClassPtr, "sessionWriter");
			Cheats.NativeMethodInfoPtr_SetSessionWriter_Public_Void_IAccountSessionWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cheats>.NativeClassPtr, 100667577);
			Cheats.NativeMethodInfoPtr_RunCheat_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cheats>.NativeClassPtr, 100667578);
			Cheats.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cheats>.NativeClassPtr, 100667579);
		}

		// Token: 0x06001ACD RID: 6861 RVA: 0x0007E9D8 File Offset: 0x0007CBD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSessionWriter(IAccountSessionWriter writer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cheats.NativeMethodInfoPtr_SetSessionWriter_Public_Void_IAccountSessionWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001ACE RID: 6862 RVA: 0x0007EA1C File Offset: 0x0007CC1C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RunCheat(string input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cheats.NativeMethodInfoPtr_RunCheat_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001ACF RID: 6863 RVA: 0x0007EA60 File Offset: 0x0007CC60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 884139, XrefRangeEnd = 884140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Cheats()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cheats>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cheats.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AD0 RID: 6864 RVA: 0x0000B8CD File Offset: 0x00009ACD
		public Cheats(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x06001AD1 RID: 6865 RVA: 0x0007EA9C File Offset: 0x0007CC9C
		// (set) Token: 0x06001AD2 RID: 6866 RVA: 0x0000B8D6 File Offset: 0x00009AD6
		public unsafe char multipleCheatArgumentDelimiter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cheats.NativeFieldInfoPtr_multipleCheatArgumentDelimiter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cheats.NativeFieldInfoPtr_multipleCheatArgumentDelimiter)) = value;
			}
		}

		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x06001AD3 RID: 6867 RVA: 0x0007EAC4 File Offset: 0x0007CCC4
		// (set) Token: 0x06001AD4 RID: 6868 RVA: 0x0000B8F1 File Offset: 0x00009AF1
		public unsafe IAccountSessionWriter sessionWriter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cheats.NativeFieldInfoPtr_sessionWriter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAccountSessionWriter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cheats.NativeFieldInfoPtr_sessionWriter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040012CB RID: 4811
		private static readonly IntPtr NativeFieldInfoPtr_multipleCheatArgumentDelimiter;

		// Token: 0x040012CC RID: 4812
		private static readonly IntPtr NativeFieldInfoPtr_sessionWriter;

		// Token: 0x040012CD RID: 4813
		private static readonly IntPtr NativeMethodInfoPtr_SetSessionWriter_Public_Void_IAccountSessionWriter_0;

		// Token: 0x040012CE RID: 4814
		private static readonly IntPtr NativeMethodInfoPtr_RunCheat_Public_Void_String_0;

		// Token: 0x040012CF RID: 4815
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
