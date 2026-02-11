using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.platform.websocket
{
	// Token: 0x02000017 RID: 23
	public class SocketDisconnected : TypedMessage
	{
		// Token: 0x06000126 RID: 294 RVA: 0x000097D8 File Offset: 0x000079D8
		// Note: this type is marked as 'beforefieldinit'.
		static SocketDisconnected()
		{
			Il2CppClassPointerStore<SocketDisconnected>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "dwd.core.platform.websocket", "SocketDisconnected");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SocketDisconnected>.NativeClassPtr);
			SocketDisconnected.NativeFieldInfoPtr_Clean = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketDisconnected>.NativeClassPtr, "Clean");
			SocketDisconnected.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketDisconnected>.NativeClassPtr, 100663533);
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00009830 File Offset: 0x00007A30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SocketDisconnected(bool clean)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SocketDisconnected>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clean;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketDisconnected.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000128 RID: 296 RVA: 0x0000264F File Offset: 0x0000084F
		public SocketDisconnected(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000129 RID: 297 RVA: 0x00009878 File Offset: 0x00007A78
		// (set) Token: 0x0600012A RID: 298 RVA: 0x00002658 File Offset: 0x00000858
		public unsafe bool Clean
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketDisconnected.NativeFieldInfoPtr_Clean);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketDisconnected.NativeFieldInfoPtr_Clean)) = value;
			}
		}

		// Token: 0x040000E2 RID: 226
		private static readonly IntPtr NativeFieldInfoPtr_Clean;

		// Token: 0x040000E3 RID: 227
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;
	}
}
