using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020002EB RID: 747
	public class CADArgHolder : Object
	{
		// Token: 0x06002E5B RID: 11867 RVA: 0x000EFA00 File Offset: 0x000EDC00
		// Note: this type is marked as 'beforefieldinit'.
		static CADArgHolder()
		{
			Il2CppClassPointerStore<CADArgHolder>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "CADArgHolder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CADArgHolder>.NativeClassPtr);
			CADArgHolder.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CADArgHolder>.NativeClassPtr, "index");
			CADArgHolder.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADArgHolder>.NativeClassPtr, 100670687);
		}

		// Token: 0x06002E5C RID: 11868 RVA: 0x000EFA58 File Offset: 0x000EDC58
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CADArgHolder(int i)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CADArgHolder>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADArgHolder.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002E5D RID: 11869 RVA: 0x0000FB84 File Offset: 0x0000DD84
		public CADArgHolder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A0C RID: 2572
		// (get) Token: 0x06002E5E RID: 11870 RVA: 0x000EFAA0 File Offset: 0x000EDCA0
		// (set) Token: 0x06002E5F RID: 11871 RVA: 0x0000FB8D File Offset: 0x0000DD8D
		public unsafe int index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADArgHolder.NativeFieldInfoPtr_index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADArgHolder.NativeFieldInfoPtr_index)) = value;
			}
		}

		// Token: 0x040026AB RID: 9899
		private static readonly IntPtr NativeFieldInfoPtr_index;

		// Token: 0x040026AC RID: 9900
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
	}
}
