using System;
using Canis.context;
using Canis.entities;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.undo
{
	// Token: 0x02000036 RID: 54
	public static class ContextUndoUtils : Object
	{
		// Token: 0x06000366 RID: 870 RVA: 0x000037DF File Offset: 0x000019DF
		// Note: this type is marked as 'beforefieldinit'.
		static ContextUndoUtils()
		{
			Il2CppClassPointerStore<ContextUndoUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.undo", "ContextUndoUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContextUndoUtils>.NativeClassPtr);
			ContextUndoUtils.NativeMethodInfoPtr_UndoNode_Public_Static_UndoNode_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextUndoUtils>.NativeClassPtr, 100664023);
		}

		// Token: 0x06000367 RID: 871 RVA: 0x00027150 File Offset: 0x00025350
		[CallerCount(29)]
		[CachedScanResults(RefRangeStart = 549971, RefRangeEnd = 550000, XrefRangeStart = 549963, XrefRangeEnd = 549971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UndoNode UndoNode(this Context context)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextUndoUtils.NativeMethodInfoPtr_UndoNode_Public_Static_UndoNode_Context_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr3) : null;
			}
		}

		// Token: 0x06000368 RID: 872 RVA: 0x00003818 File Offset: 0x00001A18
		public ContextUndoUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000240 RID: 576
		private static readonly IntPtr NativeMethodInfoPtr_UndoNode_Public_Static_UndoNode_Context_0;
	}
}
