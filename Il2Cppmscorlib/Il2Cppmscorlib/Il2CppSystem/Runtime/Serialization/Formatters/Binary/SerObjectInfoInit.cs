using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000368 RID: 872
	public sealed class SerObjectInfoInit : Object
	{
		// Token: 0x06003554 RID: 13652 RVA: 0x001088A0 File Offset: 0x00106AA0
		// Note: this type is marked as 'beforefieldinit'.
		static SerObjectInfoInit()
		{
			Il2CppClassPointerStore<SerObjectInfoInit>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "SerObjectInfoInit");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerObjectInfoInit>.NativeClassPtr);
			SerObjectInfoInit.NativeFieldInfoPtr_seenBeforeTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerObjectInfoInit>.NativeClassPtr, "seenBeforeTable");
			SerObjectInfoInit.NativeFieldInfoPtr_objectInfoIdCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerObjectInfoInit>.NativeClassPtr, "objectInfoIdCount");
			SerObjectInfoInit.NativeFieldInfoPtr_oiPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerObjectInfoInit>.NativeClassPtr, "oiPool");
			SerObjectInfoInit.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerObjectInfoInit>.NativeClassPtr, 100671435);
		}

		// Token: 0x06003555 RID: 13653 RVA: 0x00108920 File Offset: 0x00106B20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1388873, RefRangeEnd = 1388874, XrefRangeStart = 1388860, XrefRangeEnd = 1388873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerObjectInfoInit()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerObjectInfoInit>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerObjectInfoInit.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003556 RID: 13654 RVA: 0x00012FF5 File Offset: 0x000111F5
		public SerObjectInfoInit(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C53 RID: 3155
		// (get) Token: 0x06003557 RID: 13655 RVA: 0x0010895C File Offset: 0x00106B5C
		// (set) Token: 0x06003558 RID: 13656 RVA: 0x00012FFE File Offset: 0x000111FE
		public unsafe Hashtable seenBeforeTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerObjectInfoInit.NativeFieldInfoPtr_seenBeforeTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerObjectInfoInit.NativeFieldInfoPtr_seenBeforeTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C54 RID: 3156
		// (get) Token: 0x06003559 RID: 13657 RVA: 0x0010898C File Offset: 0x00106B8C
		// (set) Token: 0x0600355A RID: 13658 RVA: 0x0001301D File Offset: 0x0001121D
		public unsafe int objectInfoIdCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerObjectInfoInit.NativeFieldInfoPtr_objectInfoIdCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerObjectInfoInit.NativeFieldInfoPtr_objectInfoIdCount)) = value;
			}
		}

		// Token: 0x17000C55 RID: 3157
		// (get) Token: 0x0600355B RID: 13659 RVA: 0x001089B4 File Offset: 0x00106BB4
		// (set) Token: 0x0600355C RID: 13660 RVA: 0x00013038 File Offset: 0x00011238
		public unsafe SerStack oiPool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerObjectInfoInit.NativeFieldInfoPtr_oiPool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerStack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerObjectInfoInit.NativeFieldInfoPtr_oiPool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002BA4 RID: 11172
		private static readonly IntPtr NativeFieldInfoPtr_seenBeforeTable;

		// Token: 0x04002BA5 RID: 11173
		private static readonly IntPtr NativeFieldInfoPtr_objectInfoIdCount;

		// Token: 0x04002BA6 RID: 11174
		private static readonly IntPtr NativeFieldInfoPtr_oiPool;

		// Token: 0x04002BA7 RID: 11175
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
